def extract_warframe_components_row_data(row):
   name = row[0]
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

   neuroptics_data = extract(name, split_data[1])
   chassis_data = extract(name, split_data[2])
   systems_data = extract(name, split_data[3])
   result = neuroptics_data + chassis_data + systems_data
   return result

def extract_component_data(component_name, value):
   component_rows = value.split('<td rowspan="2" style="')
   component_rows.pop(0)
   components = []
   for row in component_rows:
      component = extract_component_row(row)
      if(len(component) > 1):
         components.append([component_name, component_category_name, component[0], resource_category_name, component[1]])
   return components

# For some reason the wiki has two ways of formatting component display - 
# one where components are referred to as blueprints (e.g. neuroptics blueprint), 
# and one where they are simply referred to by their type (e.g. neuroptics).
# This causes different algorithms to be required for each format.

def extract_component_data_without_blueprint_in_title(result_name, value):
   component_name = value.split('title="')[1].split('"')[0]
   component_name = component_name.split('Warframe')[1]
   component_name = result_name + component_name
   return extract_component_data(component_name, value)

def extract_component_data_with_blueprint_in_title(result_name, value):
   component_name = value.split("Blueprint")[0]
   return extract_component_data(component_name, value)

def extract_component_row(value):
   name = ""
   amount = 0
   if 'title' in value:
      name = value.split('title="')[1].split('"')[0]
      if name == 'Platinum':
         return ''
   else:
      name = value.split('img alt="')[1].split('.png')[0]

   amount_string = value.split("<br>")[1].split("</td>")[0]
   amount_string = amount_string.strip()
   amount_string = amount_string.replace(',', '')
   amount = int(amount_string)
   return [name, amount]

component_category_name = 'Component'
resource_category_name = 'Resource'