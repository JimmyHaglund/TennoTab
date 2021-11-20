def extract_warframe_components_row_data(row):
   name = row[0].strip()
   data = row[1]

   print(name)

   if "Manufacturing" not in data:
      print("Manufacturing keyword not found: " + name)
      return []
   split_data = data.split('<td colspan="6">')
   
   # Chroma has weird components so should be added manually, not worth adding an edge case for it at the moment
   if name == "Chroma":
      # print('Ignoring Chroma')
      return []
   
   if len(split_data) < 4:
      print('Trying to extract warframe reagents but it has the wrong number of items')
      return []

   extract = extract_component_data_without_blueprint_in_title
   if "Blueprint" in split_data[1]:
      extract = extract_component_data_with_blueprint_in_title

   frame_data = extract_warframe_blueprint_data(name, split_data[0])
   neuroptics_data = extract(name, split_data[1])
   chassis_data = extract(name, split_data[2])
   systems_data = extract(name, split_data[3])
   result = frame_data + neuroptics_data + chassis_data + systems_data
   return result

def extract_component_data(result_name, raw_data):
   component_rows = raw_data.split('<td rowspan="2" style="')
   component_rows.pop(0)
   components = []
   for row in component_rows:
      component_data = extract_component_row(row.split('</td>')[0])
      if(len(component_data) > 1):
         component_name = component_data[0]
         component_amount = component_data[1]
         components.append([result_name, component_name, component_amount])
   return components

def extract_warframe_blueprint_data(warframe_name, raw_data):
   component_rows = raw_data.split('<td rowspan="2" style="')
   component_rows.pop(0)
   components = []
   
   chassis_name = warframe_name + ' Chassis'
   neuroptics_name = warframe_name + ' Neuroptics'
   systems_name = warframe_name + ' Systems'
   component_names = ['Credits', chassis_name, neuroptics_name, systems_name]
   
   for n in range(0, len(component_rows) - 1):
      row = component_rows[n]
      component_name = component_names[n]
      component_data = extract_component_row(row)
      if(len(component_data) < 2):
         continue
      component_amount = component_data[1]
      components.append([warframe_name, component_name, component_amount])
   return components

# For some reason the wiki has two ways of formatting component display - 
# one where components are referred to as blueprints (e.g. neuroptics blueprint), 
# and one where they are simply referred to by their type (e.g. neuroptics).
# This causes different algorithms to be required for each format.

def extract_component_data_without_blueprint_in_title(result_name, value):
   component_name = value.split('title="')[1].split('"')[0]
   component_name = component_name.split('Warframe')[1]
   component_name = (result_name + component_name).strip()
   return extract_component_data(component_name, value)

def extract_component_data_with_blueprint_in_title(result_name, value):
   component_name = value.split("Blueprint")[0].strip()
   return extract_component_data(component_name, value)

def extract_component_row(value):
   name = ""
   amount = 0
   split_data = value.split('</a>')
   if len(split_data) < 2:
      return ''

   name_data_block = split_data[0]
   amount_data_block = split_data[1]
   if 'title' in name_data_block:
      name = name_data_block.split('title="')[1].split('"')[0]
   elif 'img alt="' in name_data_block:
      name = name_data_block.split('alt="')[1].split('.png')[0]
   else:
      print('no title found')
      return ''
   amount = 1
   if '<br>' in amount_data_block:
      amount_string = amount_data_block.split("</td>")[0].split('<br>')[1].strip()
      amount_string = amount_string.strip()
      amount_string = amount_string.replace(',', '')
      amount = int(amount_string)
   return [name, amount]