namespace WarframeProgressTrackerApi.Models {
    public abstract class UserCollectible {
        public string UserId { get; set; }
        public int ItemId { get; set; }
        public int MasteryRank { get; set; } = 0;
        public bool Obtained { get; set; } = false;
        public bool OnWishlist { get; set; } = false;
    }

    public class UserFrame : UserCollectible { }
    public class UserPrimaryWeapon : UserCollectible { }
    public class UserSecondaryWeapon : UserCollectible { }
    public class UserMeleeWeapon : UserCollectible { }
    public class UserPet : UserCollectible { }
    public class UserAmp : UserCollectible { }
    public class UserRoboGun : UserCollectible { }
    public class UserArchwing : UserCollectible { }
    public class UserArchGun : UserCollectible { }
    public class UserArchMelee : UserCollectible { }
}
