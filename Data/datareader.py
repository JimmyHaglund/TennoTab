import csv
import os

raw_directory = '0_Raw'
suffix = '.csv'

frame_file_name = 'warframewiki_warframeblueprints'
primeframe_file_name = 'warframewiki_primeframeblueprints'

primaryweapons_file_name = 'warframewiki_primaryweaponblueprints'
secondaryweapons_file_name = 'warframewiki_secondaryweaponblueprints'
meleeweapons_file_name = 'warframewiki_meleeweaponblueprints'

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

def read_frame_files():
   base_frames = read_csv(frame_file_name)
   prime_frames = read_csv(primeframe_file_name)
   remove_first_columns(base_frames, 2)
   remove_first_columns(prime_frames, 2)
   for frame in base_frames:
      name = frame[1].split('/').pop()
      frame[1] = name
   for frame in prime_frames:
      name = frame[0].split('Â')[0]
      frame[1] = name + ' Prime'
   frames = base_frames + prime_frames
   remove_first_column(frames)
   return frames

def read_weapon_files():
   primary_weapons = read_csv(primaryweapons_file_name)
   secondary_weapons = read_csv(secondaryweapons_file_name)
   melee_weapons = read_csv(meleeweapons_file_name)
   weapons = primary_weapons + secondary_weapons + melee_weapons
   remove_first_columns(weapons, 2)
   for weapon in weapons:
      if weapon[0] == "Prime":
         name = weapon[1].split('/').pop().split('_')[0]
         weapon[0] = name + " Prime"
      weapon.pop(1)
   return weapons