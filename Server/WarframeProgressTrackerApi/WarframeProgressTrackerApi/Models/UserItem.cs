namespace WarframeProgressTrackerApi.Models {
    public abstract class UserItem {
        public string UserId { get; set; }
        public int ItemId { get; set; }
        public int MasteryRank { get; set; } = 0;
        public bool Obtained { get; set; } = false;
        public bool OnWishlist { get; set; } = false;
    }

    public class UserFrame : UserItem { }
    public class UserPrimaryWeapon : UserItem { }
    public class UserSecondaryWeapon : UserItem { }
    public class UserMeleeWeapon : UserItem { }
    public class UserPet : UserItem { }
    public class UserAmp : UserItem { }
    public class UserRoboGun : UserItem { }
    public class UserArchwing : UserItem { }
    public class UserArchGun : UserItem { }
    public class UserArchMelee : UserItem { }
}
