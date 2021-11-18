name_dictionary = {
   'DENitainExtract': 'Nitain Extract',
   'Forma2': 'Forma',
   'Tellurium Market': 'Tellurium',
   'TelluriumMarket': 'Tellurium'
}

def filter(name):
   if name in name_dictionary:
      return name_dictionary[name]
   return space_between_capitals(name)

def add_title_to_specific_component_name(name, result_name):
   sword_names = ['Blade', 'Grip', 'Guard', 'Core', 'Disc', 'Engine', 'Heatsink', 'Hilt']
   gauntlet_names = ['Gauntlet', 'Boot', 'Blades', 'Left Gauntlet', 'Right Gauntlet', 'Rivet']
   hammer_names = ['Head', 'Motor', 'Ornament']
   melee_names = sword_names + gauntlet_names + hammer_names
   
   bow_names = ['Lower Limb','Upper Limb', 'String']
   throwing_names = ['Pouch', 'Stars']
   gun_names = ['Barrel', 'Link', 'Receiver', 'Chassis', 'Handle', 'Stock', 'Subcortex']
   ranged_names = bow_names + throwing_names + gun_names
   
   component_names = melee_names + ranged_names
   if name in component_names:
      return result_name + ' ' + name
   return name

def space_between_capitals(text):
   if len(text) == 0:
      return ''
   result = text[0]
   space = ' '
   for n in range(1, len(text)):
      character = text[n]
      previous_character = text[n-1]
      capitalized = character.upper()

      if character.isspace():
         result += space
         continue
      
      if character == capitalized and not previous_character.isspace():
         result += space
         n += 1

      result += character
   return result

# spaced_string = space_between_capitals('JimmyHaglund')
# print(spaced_string)