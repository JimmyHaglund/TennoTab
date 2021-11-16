import csv
import os

raw_directory = '0_Raw'
suffix = '.csv'

class BlueprintFileNames: 
   frames = 'warframewiki_warframeblueprints'
   prime_frames = 'warframewiki_primeframeblueprints'
   
   primary_weapons = 'warframewiki_primaryweaponblueprints'
   secondary_weapons = 'warframewiki_secondaryweaponblueprints'
   melee_weapons = 'warframewiki_meleeweaponblueprints'

class SourceFileNames:
   frames = 'warframewiki_warframesources'
   # prime_frames = 'warframewiki_primeframesources'
   primary_weapons = 'warframewiki_primaryweaponsources'
   secondary_weapons = 'warframewiki_secondaryweaponsources'
   melee_weapons = 'warframewiki_meleeweaponsources'

def working_path(folder_name):
   working_directory = os.getcwd()
   return os.path.join(working_directory, folder_name)

def read_csv(name):
   result = []
   path = os.path.join(working_path(raw_directory), name + suffix)
   with open(path) as csvfile:
      rows = csv.reader(csvfile, delimiter=',')
      for row in rows:
         result.append(row)
   result.pop(0)
   return result

def remove_first_column(target):
   for row in target:
      row.pop(0)

def remove_first_columns(target, columns_to_remove):
   for row in target:
      for i in range(columns_to_remove):
         row.pop(0)

def read_frame_blueprint_files():
   blueprint_file_names = BlueprintFileNames()
   base_frames = read_csv(blueprint_file_names.frames)
   prime_frames = read_csv(blueprint_file_names.prime_frames)
   
   remove_first_columns(base_frames, 2)
   remove_first_columns(prime_frames, 2)
   for frame in base_frames:
      name = frame[1].split('/').pop().strip()
      if name == 'Prime':
         name = frame[1].split('/').pop() + name
      frame[1] = name
   for frame in prime_frames:
      name = frame[0].split('Â')[0]
      frame[1] = name + ' Prime'
   frames = base_frames + prime_frames
   remove_first_column(frames)
   return frames

def read_weapon_blueprint_files():
   blueprint_file_names = BlueprintFileNames()
   
   primary_weapons = read_csv(blueprint_file_names.primary_weapons)
   secondary_weapons = read_csv(blueprint_file_names.secondary_weapons)
   melee_weapons = read_csv(blueprint_file_names.melee_weapons)
   weapons = primary_weapons + secondary_weapons + melee_weapons
   
   remove_first_columns(weapons, 2)
   
   for weapon in weapons:
      if weapon[0] == "Prime":
         name = weapon[1].split('/').pop().split('_')[0]
         weapon[0] = name + " Prime"
      weapon.pop(1)
   return weapons

def read_item_source_files():
   source_file_names = SourceFileNames()
   frame_sources = read_csv(source_file_names.frames)
   # prime_frame_sources = read_csv(source_file_names.prime_frames)

   primary_weapon_sources = read_csv(source_file_names.primary_weapons)
   secondary_weapon_sources = read_csv(source_file_names.secondary_weapons)
   melee_weapon_sources = read_csv(source_file_names.melee_weapons)

   sources = frame_sources + primary_weapon_sources + secondary_weapon_sources + melee_weapon_sources
   remove_first_columns(sources, 3)
   return sources