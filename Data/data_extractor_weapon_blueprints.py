def extract_weapon_components_row_data(raw_data_row):
   result = []
   weapon_name = raw_data_row[0].strip()
   raw_data = raw_data_row[1]
   # print(name)
   if 'Research' in raw_data:
      raw_data = raw_data.split('Research')[0]

   if "Manufacturing" not in raw_data:
      print("Manufacturing keyword not found: " + weapon_name)
      return []

   weapon_blueprint_data = raw_data.split('<td colspan="6">')
   n = 0
   for component_blueprint_data in weapon_blueprint_data:
      result_name = weapon_name
      
      if n > 0:
         component_name = component_blueprint_data.split('</td')[0].split('â€¢')[0].strip()
         result_name = weapon_name + ' ' + component_name
      
      extract = extract_component_data_without_blueprint_in_title
      if "Blueprint" in raw_data:
         extract = extract_component_data_with_blueprint_in_title

      result += extract(result_name, component_blueprint_data)
      n += 1
   return result

def extract_component_data(result_name, value):
   component_rows = value.split('<td rowspan="2" style="')
   component_rows.pop(0)
   components = []
   for row in component_rows:
      component_data = extract_component_row(row)
      if component_data == 'Platinum':
         continue
      if len(component_data) < 2:
         continue
      component_name = component_data[0]
      component_amount = component_data[1]
      append_component(result_name, component_name, component_amount, components)
      # components.append([result_name, component_name, component_amount])
   return components

def append_component(result_name, component_name, component_amount, components):
   for component_row in components:
      row_component_name = component_row[1]
      if row_component_name == component_name:
         component_row[2] += component_amount
         return
   components.append([result_name, component_name, component_amount])

# For some reason the wiki has two ways of formatting component display - 
# one where components are referred to as blueprints (e.g. neuroptics blueprint), 
# and one where they are simply referred to by their type (e.g. neuroptics).
# This causes different algorithms to be required for each format.

def extract_component_data_without_blueprint_in_title(result_name, value):
   # component_name = value.split('title="')[1].split('"')[0]
   # component_name = component_name.split('Weapon')[1]
   # component_name = result_name + component_name
   return extract_component_data(result_name, value)

def extract_component_data_with_blueprint_in_title(result_name, value):
   # component_name = value.split("Blueprint")[0]
   return extract_component_data(result_name, value)

def extract_component_row(value):
   name = ""
   amount = 0
   split_data = value.split('<br>')
   if len(split_data) < 2:
      return ''

   name_data_block = split_data[0]
   amount_data_block = split_data[1]
   if 'title' in name_data_block:
      name = name_data_block.split('title="')[1].split('"')[0]
   elif 'img alt="' in name_data_block:
      name = name_data_block.split('img alt="')[1].split('.png')[0]
   else:
      print('no title found')
      return ''

   amount_string = amount_data_block.split("</td>")[0].strip()
   amount_string = amount_string.strip()
   amount_string = amount_string.replace(',', '')
   amount = int(amount_string)
   # print(name + ',' + amount_string)
   return [name, amount]

component_category_name = 'Weapon'
resource_category_name = 'Resource'