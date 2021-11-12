def extract_weapon_components_row_data(row):
   name = row[0]
   data = row[1]
   # print(name)
   if 'Research' in data:
      data = data.split('Research')[0]

   if "Manufacturing" not in data:
      print("Manufacturing keyword not found: " + name)
      return []

   extract = extract_component_data_without_blueprint_in_title
   if "Blueprint" in data:
      extract = extract_component_data_with_blueprint_in_title

   result = extract(name, data)
   # print(result)
   # print(name)
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
   if 'title' in value:
      name = value.split('title="')[1].split('"')[0]
      if name == 'Platinum':
         return ''
   elif 'img alt="' in value:
      name = value.split('img alt="')[1].split('.png')[0]
   else:
      return ''

   amount_string = value.split("<br>")[1].split("</td>")[0]
   amount_string = amount_string.strip()
   amount_string = amount_string.replace(',', '')
   amount = int(amount_string)
   return [name, amount]

component_category_name = 'Weapon'
resource_category_name = 'Resource'