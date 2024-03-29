import csv
import datareader, datawriter
import data_extractor_warframe_blueprints
import data_extractor_weapon_blueprints
import name_filter

component_category_name = 'Component'
resource_category_name = 'Resource'

frames_raw = datareader.read_frame_blueprint_files()
weapons_raw = datareader.read_weapon_blueprint_files()

# print('processing ' + str(len(weapons_raw)) + ' weapons')
result = []
for frame in frames_raw:
   data = data_extractor_warframe_blueprints.extract_warframe_components_row_data(frame)
   if len(data) == 0:
      continue
   result = result + data

for weapon in weapons_raw:
   data = data_extractor_weapon_blueprints.extract_weapon_components_row_data(weapon)
   if len(data) == 0:
      continue
   result = result + data

for value in result:
   value[1] = name_filter.filter(value[1].strip())
   value[1] = name_filter.add_title_to_specific_component_name(value[1], value[0])
   # print(value)
result = [['ItemName', 'ComponentName', 'ComponentAmount']] + result
datawriter.write_csv("BlueprintsComponents", result)