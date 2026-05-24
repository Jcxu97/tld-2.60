using Cpp2ILInjected;

namespace AK;

[Token(Token = "0x2000B4B")]
public static class SWITCHES
{
	[Token(Token = "0x2000B4C")]
	public static class AFFLICTION
	{
		[Token(Token = "0x2000B4D")]
		public static class SWITCH
		{
			[Token(Token = "0x4007591")]
			public const uint BLOODLOSS = 3119702466u;

			[Token(Token = "0x4007592")]
			public const uint BURNS = 3280370741u;

			[Token(Token = "0x4007593")]
			public const uint DYSENTERY = 517421752u;

			[Token(Token = "0x4007594")]
			public const uint FOODPOISONING = 3349208223u;

			[Token(Token = "0x4007595")]
			public const uint GENERAL = 133642231u;

			[Token(Token = "0x4007596")]
			public const uint INFECTION = 1748902224u;

			[Token(Token = "0x4007597")]
			public const uint INTESTINALPARASITES = 1991292580u;

			[Token(Token = "0x4007598")]
			public const uint NOAFFLICTION = 103485017u;
		}

		[Token(Token = "0x4007590")]
		public const uint GROUP = 2075883972u;
	}

	[Token(Token = "0x2000B4E")]
	public static class AISTATE
	{
		[Token(Token = "0x2000B4F")]
		public static class SWITCH
		{
			[Token(Token = "0x400759A")]
			public const uint ATTACK = 180661997u;

			[Token(Token = "0x400759B")]
			public const uint DEAD = 2044049779u;

			[Token(Token = "0x400759C")]
			public const uint FEEDING = 3464963039u;

			[Token(Token = "0x400759D")]
			public const uint FLEE = 2864273045u;

			[Token(Token = "0x400759E")]
			public const uint FOLLOWWAYPOINTS = 790866902u;

			[Token(Token = "0x400759F")]
			public const uint HOLDGROUND = 1126185955u;

			[Token(Token = "0x40075A0")]
			public const uint IDLE = 1874288895u;

			[Token(Token = "0x40075A1")]
			public const uint INVESTIGATE = 2041902182u;

			[Token(Token = "0x40075A2")]
			public const uint INVESTIGATEFOOD = 3671729142u;

			[Token(Token = "0x40075A3")]
			public const uint INVESTIGATESMELL = 3601743519u;

			[Token(Token = "0x40075A4")]
			public const uint ROOTED = 1037331606u;

			[Token(Token = "0x40075A5")]
			public const uint SLEEP = 3671647190u;

			[Token(Token = "0x40075A6")]
			public const uint STALKING = 3070922666u;

			[Token(Token = "0x40075A7")]
			public const uint STRUGGLE = 1710664868u;

			[Token(Token = "0x40075A8")]
			public const uint WANDER = 2738890606u;

			[Token(Token = "0x40075A9")]
			public const uint WANDERPAUSED = 1379378872u;
		}

		[Token(Token = "0x4007599")]
		public const uint GROUP = 2074760654u;
	}

	[Token(Token = "0x2000B50")]
	public static class ANIMAL
	{
		[Token(Token = "0x2000B51")]
		public static class SWITCH
		{
			[Token(Token = "0x40075AB")]
			public const uint BEAR = 1190179415u;

			[Token(Token = "0x40075AC")]
			public const uint COUGAR = 3891313266u;

			[Token(Token = "0x40075AD")]
			public const uint CROW = 4237424144u;

			[Token(Token = "0x40075AE")]
			public const uint DOE = 546651183u;

			[Token(Token = "0x40075AF")]
			public const uint MOOSE = 1060713240u;

			[Token(Token = "0x40075B0")]
			public const uint PTARMIGAN = 1458493528u;

			[Token(Token = "0x40075B1")]
			public const uint RABBIT = 2689485353u;

			[Token(Token = "0x40075B2")]
			public const uint STAG = 553997892u;

			[Token(Token = "0x40075B3")]
			public const uint TIMBERWOLF = 1475911652u;

			[Token(Token = "0x40075B4")]
			public const uint WOLF = 2041272125u;
		}

		[Token(Token = "0x40075AA")]
		public const uint GROUP = 767988009u;
	}

	[Token(Token = "0x2000B52")]
	public static class ANIMALCOUGARDISTANCE
	{
		[Token(Token = "0x2000B53")]
		public static class SWITCH
		{
			[Token(Token = "0x40075B6")]
			public const uint ACD_DISTANT_300 = 382818903u;

			[Token(Token = "0x40075B7")]
			public const uint ACD_FAR_150 = 806293966u;

			[Token(Token = "0x40075B8")]
			public const uint ACD_MEDIUM_075 = 3366307930u;

			[Token(Token = "0x40075B9")]
			public const uint ACD_NEAR_0 = 977378125u;
		}

		[Token(Token = "0x40075B5")]
		public const uint GROUP = 3660894491u;
	}

	[Token(Token = "0x2000B54")]
	public static class ANIMALCOUGARLOCOMOTION
	{
		[Token(Token = "0x2000B55")]
		public static class SWITCH
		{
			[Token(Token = "0x40075BB")]
			public const uint ACL_CANTER = 55689101u;

			[Token(Token = "0x40075BC")]
			public const uint ACL_GALLOP = 2073822515u;

			[Token(Token = "0x40075BD")]
			public const uint ACL_TROT = 3838870853u;

			[Token(Token = "0x40075BE")]
			public const uint ACL_WALK = 2568265245u;

			[Token(Token = "0x40075BF")]
			public const uint ACL_WALKINJURED = 1815579828u;
		}

		[Token(Token = "0x40075BA")]
		public const uint GROUP = 2233465569u;
	}

	[Token(Token = "0x2000B56")]
	public static class ANIMALPTARMIGANFLYINGSWITCH
	{
		[Token(Token = "0x2000B57")]
		public static class SWITCH
		{
			[Token(Token = "0x40075C1")]
			public const uint ANMLPTARMIGANFLYING_GROUND = 2538327831u;

			[Token(Token = "0x40075C2")]
			public const uint ANMLPTARMIGANFLYING_INAIR = 1361998445u;

			[Token(Token = "0x40075C3")]
			public const uint ANMLPTARMIGANFLYING_TAKEOFF = 1654037138u;
		}

		[Token(Token = "0x40075C0")]
		public const uint GROUP = 1415176369u;
	}

	[Token(Token = "0x2000B58")]
	public static class ANXIETYLEVEL
	{
		[Token(Token = "0x2000B59")]
		public static class SWITCH
		{
			[Token(Token = "0x40075C5")]
			public const uint HIGH = 3550808449u;

			[Token(Token = "0x40075C6")]
			public const uint LOW = 545371365u;

			[Token(Token = "0x40075C7")]
			public const uint MED = 981339021u;
		}

		[Token(Token = "0x40075C4")]
		public const uint GROUP = 1446207487u;
	}

	[Token(Token = "0x2000B5A")]
	public static class AUDIOTRACKTEST
	{
		[Token(Token = "0x2000B5B")]
		public static class SWITCH
		{
			[Token(Token = "0x40075C9")]
			public const uint MUSICGROUP1 = 2915405956u;

			[Token(Token = "0x40075CA")]
			public const uint MUSICGROUP2 = 2915405959u;

			[Token(Token = "0x40075CB")]
			public const uint MUSICGROUP3 = 2915405958u;

			[Token(Token = "0x40075CC")]
			public const uint MUSICGROUP4 = 2915405953u;
		}

		[Token(Token = "0x40075C8")]
		public const uint GROUP = 3711254590u;
	}

	[Token(Token = "0x2000B5C")]
	public static class AURORA
	{
		[Token(Token = "0x2000B5D")]
		public static class SWITCH
		{
			[Token(Token = "0x40075CE")]
			public const uint AURORAOFF = 3898283308u;

			[Token(Token = "0x40075CF")]
			public const uint AURORAON = 736463814u;
		}

		[Token(Token = "0x40075CD")]
		public const uint GROUP = 1707964461u;
	}

	[Token(Token = "0x2000B5E")]
	public static class AURORA_TRADER
	{
		[Token(Token = "0x2000B5F")]
		public static class SWITCH
		{
			[Token(Token = "0x40075D1")]
			public const uint AT_OFF = 3575300340u;

			[Token(Token = "0x40075D2")]
			public const uint AT_ON = 3042009198u;
		}

		[Token(Token = "0x40075D0")]
		public const uint GROUP = 3433954548u;
	}

	[Token(Token = "0x2000B60")]
	public static class AURORAELECTROLIZERONOFF
	{
		[Token(Token = "0x2000B61")]
		public static class SWITCH
		{
			[Token(Token = "0x40075D4")]
			public const uint AURORAELECTROLIZEROFF = 3245231844u;

			[Token(Token = "0x40075D5")]
			public const uint AURORAELECTROLIZERON = 735842494u;
		}

		[Token(Token = "0x40075D3")]
		public const uint GROUP = 1690529165u;
	}

	[Token(Token = "0x2000B62")]
	public static class CHEMICALHAZARDRISK
	{
		[Token(Token = "0x2000B63")]
		public static class SWITCH
		{
			[Token(Token = "0x40075D7")]
			public const uint CHR_FALSE = 447477810u;

			[Token(Token = "0x40075D8")]
			public const uint CHR_TRUE = 1023079049u;
		}

		[Token(Token = "0x40075D6")]
		public const uint GROUP = 4109011572u;
	}

	[Token(Token = "0x2000B64")]
	public static class CHEMICALHAZARDZONESWITCH
	{
		[Token(Token = "0x2000B65")]
		public static class SWITCH
		{
			[Token(Token = "0x40075DA")]
			public const uint CHZ_ENTER = 1810812025u;

			[Token(Token = "0x40075DB")]
			public const uint CHZ_FALSE = 1064931802u;

			[Token(Token = "0x40075DC")]
			public const uint CHZ_TRUE = 2998773073u;
		}

		[Token(Token = "0x40075D9")]
		public const uint GROUP = 4083080415u;
	}

	[Token(Token = "0x2000B66")]
	public static class CLOTHINGREGION_CHEST
	{
		[Token(Token = "0x2000B67")]
		public static class SWITCH
		{
			[Token(Token = "0x40075DE")]
			public const uint CRCHEST__NULL = 3090198920u;

			[Token(Token = "0x40075DF")]
			public const uint CRCHEST_HEAVYNYLON = 1120155913u;

			[Token(Token = "0x40075E0")]
			public const uint CRCHEST_LEATHER = 2932723963u;

			[Token(Token = "0x40075E1")]
			public const uint CRCHEST_LIGHTCOTTON = 499287193u;

			[Token(Token = "0x40075E2")]
			public const uint CRCHEST_LIGHTNYLON = 1184850526u;

			[Token(Token = "0x40075E3")]
			public const uint CRCHEST_SOFTCLOTH = 1027550648u;

			[Token(Token = "0x40075E4")]
			public const uint CRCHEST_WOOL = 4076097731u;
		}

		[Token(Token = "0x40075DD")]
		public const uint GROUP = 513068703u;
	}

	[Token(Token = "0x2000B68")]
	public static class CLOTHINGREGION_FEET
	{
		[Token(Token = "0x2000B69")]
		public static class SWITCH
		{
			[Token(Token = "0x40075E6")]
			public const uint CRFEET_BAREFOOT = 3875881613u;

			[Token(Token = "0x40075E7")]
			public const uint CRFEET_BOOT = 3475601u;

			[Token(Token = "0x40075E8")]
			public const uint CRFEET_DEERSKIN = 377929790u;

			[Token(Token = "0x40075E9")]
			public const uint CRFEET_LEATHERSHOES = 1117331384u;

			[Token(Token = "0x40075EA")]
			public const uint CRFEET_SKIBOOTS = 2570308255u;

			[Token(Token = "0x40075EB")]
			public const uint CRFEET_SNEAKER = 2785736670u;

			[Token(Token = "0x40075EC")]
			public const uint CRFEET_SOCKS = 86401284u;

			[Token(Token = "0x40075ED")]
			public const uint CRFEET_WORKBOOT = 2593817162u;
		}

		[Token(Token = "0x40075E5")]
		public const uint GROUP = 179510716u;
	}

	[Token(Token = "0x2000B6A")]
	public static class CLOTHINGREGION_HANDS
	{
		[Token(Token = "0x2000B6B")]
		public static class SWITCH
		{
			[Token(Token = "0x40075EF")]
			public const uint CRHANDS_COVERED = 3300293463u;

			[Token(Token = "0x40075F0")]
			public const uint CRHANDS_UNCOVERED = 538520284u;
		}

		[Token(Token = "0x40075EE")]
		public const uint GROUP = 2551642506u;
	}

	[Token(Token = "0x2000B6C")]
	public static class CLOTHINGREGION_HEAD
	{
		[Token(Token = "0x2000B6D")]
		public static class SWITCH
		{
			[Token(Token = "0x40075F2")]
			public const uint CRHEAD_COVERED = 3449460039u;

			[Token(Token = "0x40075F3")]
			public const uint CRHEAD_UNCOVERED = 2074889836u;
		}

		[Token(Token = "0x40075F1")]
		public const uint GROUP = 504766238u;
	}

	[Token(Token = "0x2000B6E")]
	public static class CLOTHINGREGION_LEGS
	{
		[Token(Token = "0x2000B6F")]
		public static class SWITCH
		{
			[Token(Token = "0x40075F5")]
			public const uint CRLEGS__NULL = 78745484u;

			[Token(Token = "0x40075F6")]
			public const uint CRLEGS_HEAVYNYLON = 3797663437u;

			[Token(Token = "0x40075F7")]
			public const uint CRLEGS_LEATHER = 2742535431u;

			[Token(Token = "0x40075F8")]
			public const uint CRLEGS_LIGHTCOTTON = 3198557653u;

			[Token(Token = "0x40075F9")]
			public const uint CRLEGS_LIGHTNYLON = 476582138u;

			[Token(Token = "0x40075FA")]
			public const uint CRLEGS_SOFTCLOTH = 3180144852u;

			[Token(Token = "0x40075FB")]
			public const uint CRLEGS_WOOL = 708849367u;
		}

		[Token(Token = "0x40075F4")]
		public const uint GROUP = 2899962935u;
	}

	[Token(Token = "0x2000B70")]
	public static class COOKINGSTATUSSWITCH
	{
		[Token(Token = "0x2000B71")]
		public static class SWITCH
		{
			[Token(Token = "0x40075FD")]
			public const uint COOKINGSTATUS_INPROGRESS = 2514381840u;

			[Token(Token = "0x40075FE")]
			public const uint COOKINGSTATUS_NO = 4281252533u;

			[Token(Token = "0x40075FF")]
			public const uint COOKINGSTATUS_YES = 1432087705u;
		}

		[Token(Token = "0x40075FC")]
		public const uint GROUP = 3919761141u;
	}

	[Token(Token = "0x2000B72")]
	public static class COOKINGSURFACE
	{
		[Token(Token = "0x2000B73")]
		public static class SWITCH
		{
			[Token(Token = "0x4007601")]
			public const uint COOKINGSURFACE_FORGE = 2198731172u;

			[Token(Token = "0x4007602")]
			public const uint COOKINGSURFACE_GRILL = 3788379793u;

			[Token(Token = "0x4007603")]
			public const uint COOKINGSURFACE_STONE = 2086161170u;

			[Token(Token = "0x4007604")]
			public const uint COOKINGSURFACE_STOVE = 2220382314u;
		}

		[Token(Token = "0x4007600")]
		public const uint GROUP = 1278661908u;
	}

	[Token(Token = "0x2000B74")]
	public static class CRAMPONS
	{
		[Token(Token = "0x2000B75")]
		public static class SWITCH
		{
			[Token(Token = "0x4007606")]
			public const uint DEQUIPPED = 1822846260u;

			[Token(Token = "0x4007607")]
			public const uint EQUIPPED = 1780230126u;
		}

		[Token(Token = "0x4007605")]
		public const uint GROUP = 712608014u;
	}

	[Token(Token = "0x2000B76")]
	public static class CUTTINGTOOL
	{
		[Token(Token = "0x2000B77")]
		public static class SWITCH
		{
			[Token(Token = "0x4007609")]
			public const uint HACKSAW = 282120001u;

			[Token(Token = "0x400760A")]
			public const uint HAMMER = 703486095u;

			[Token(Token = "0x400760B")]
			public const uint HANDS = 1696692325u;

			[Token(Token = "0x400760C")]
			public const uint HATCHET = 425530526u;

			[Token(Token = "0x400760D")]
			public const uint KNIFE = 3312069844u;
		}

		[Token(Token = "0x4007608")]
		public const uint GROUP = 404179341u;
	}

	[Token(Token = "0x2000B78")]
	public static class DAYNIGHT
	{
		[Token(Token = "0x2000B79")]
		public static class SWITCH
		{
			[Token(Token = "0x400760F")]
			public const uint DAY = 311764537u;

			[Token(Token = "0x4007610")]
			public const uint NIGHT = 1011622525u;
		}

		[Token(Token = "0x400760E")]
		public const uint GROUP = 1705516017u;
	}

	[Token(Token = "0x2000B7A")]
	public static class ENTITYDISTANCE
	{
		[Token(Token = "0x2000B7B")]
		public static class SWITCH
		{
			[Token(Token = "0x4007612")]
			public const uint FAR = 1183803292u;

			[Token(Token = "0x4007613")]
			public const uint MID = 1182670505u;

			[Token(Token = "0x4007614")]
			public const uint NEAR = 1133794587u;
		}

		[Token(Token = "0x4007611")]
		public const uint GROUP = 1888227761u;
	}

	[Token(Token = "0x2000B7C")]
	public static class ENTITYINTENSITY
	{
		[Token(Token = "0x2000B7D")]
		public static class SWITCH
		{
			[Token(Token = "0x4007616")]
			public const uint HIGH = 3550808449u;

			[Token(Token = "0x4007617")]
			public const uint LOW = 545371365u;

			[Token(Token = "0x4007618")]
			public const uint MED = 981339021u;
		}

		[Token(Token = "0x4007615")]
		public const uint GROUP = 3949411123u;
	}

	[Token(Token = "0x2000B7E")]
	public static class ENVIRONMENT
	{
		[Token(Token = "0x2000B7F")]
		public static class SWITCH
		{
			[Token(Token = "0x400761A")]
			public const uint EXTERIOR = 2213992659u;

			[Token(Token = "0x400761B")]
			public const uint INTERIOR = 1132214669u;
		}

		[Token(Token = "0x4007619")]
		public const uint GROUP = 1229948536u;
	}

	[Token(Token = "0x2000B80")]
	public static class FLASKVOLUME
	{
		[Token(Token = "0x2000B81")]
		public static class SWITCH
		{
			[Token(Token = "0x400761D")]
			public const uint FLASKVOLUME_EMPTY = 1314023310u;

			[Token(Token = "0x400761E")]
			public const uint FLASKVOLUME_FULL = 682920536u;

			[Token(Token = "0x400761F")]
			public const uint FLASKVOLUME_PARTIAL = 583279594u;
		}

		[Token(Token = "0x400761C")]
		public const uint GROUP = 2310478668u;
	}

	[Token(Token = "0x2000B82")]
	public static class GEARPLACEMENT
	{
		[Token(Token = "0x2000B83")]
		public static class SWITCH
		{
			[Token(Token = "0x4007621")]
			public const uint GP_FALSE = 3933349528u;

			[Token(Token = "0x4007622")]
			public const uint GP_TRUE = 2896364951u;
		}

		[Token(Token = "0x4007620")]
		public const uint GROUP = 2858391005u;
	}

	[Token(Token = "0x2000B84")]
	public static class HANDHELDSHORTWAVE_TRACKINGMODESWITCH
	{
		[Token(Token = "0x2000B85")]
		public static class SWITCH
		{
			[Token(Token = "0x4007624")]
			public const uint HSTM_BUNKER = 1507008265u;

			[Token(Token = "0x4007625")]
			public const uint HSTM_CACHE = 127617116u;
		}

		[Token(Token = "0x4007623")]
		public const uint GROUP = 1657573713u;
	}

	[Token(Token = "0x2000B86")]
	public static class HOWLDISTANCE
	{
		[Token(Token = "0x2000B87")]
		public static class SWITCH
		{
			[Token(Token = "0x4007627")]
			public const uint FAR = 1183803292u;

			[Token(Token = "0x4007628")]
			public const uint NEAR = 1133794587u;
		}

		[Token(Token = "0x4007626")]
		public const uint GROUP = 1358869094u;
	}

	[Token(Token = "0x2000B88")]
	public static class ITEMCONDITION
	{
		[Token(Token = "0x2000B89")]
		public static class SWITCH
		{
			[Token(Token = "0x400762A")]
			public const uint HIGH = 3550808449u;

			[Token(Token = "0x400762B")]
			public const uint LOW = 545371365u;

			[Token(Token = "0x400762C")]
			public const uint MED = 981339021u;
		}

		[Token(Token = "0x4007629")]
		public const uint GROUP = 3731891983u;
	}

	[Token(Token = "0x2000B8A")]
	public static class LIQUIDS
	{
		[Token(Token = "0x2000B8B")]
		public static class SWITCH
		{
			[Token(Token = "0x400762E")]
			public const uint LIQUID_ANTISEPTIC = 1752268720u;

			[Token(Token = "0x400762F")]
			public const uint LIQUID_BROTH = 2927616223u;

			[Token(Token = "0x4007630")]
			public const uint LIQUID_COFFEE = 416957812u;

			[Token(Token = "0x4007631")]
			public const uint LIQUID_FUEL = 969023132u;

			[Token(Token = "0x4007632")]
			public const uint LIQUID_OIL = 186107776u;

			[Token(Token = "0x4007633")]
			public const uint LIQUID_TEA = 248834090u;

			[Token(Token = "0x4007634")]
			public const uint LIQUID_WATER = 1728261221u;
		}

		[Token(Token = "0x400762D")]
		public const uint GROUP = 1763382076u;
	}

	[Token(Token = "0x2000B8C")]
	public static class MATERIALTAG
	{
		[Token(Token = "0x2000B8D")]
		public static class SWITCH
		{
			[Token(Token = "0x4007636")]
			public const uint CLIFF = 1668395945u;

			[Token(Token = "0x4007637")]
			public const uint CLOTH = 1367384683u;

			[Token(Token = "0x4007638")]
			public const uint CONVEYORBELT = 1687970961u;

			[Token(Token = "0x4007639")]
			public const uint DIRT = 2195636714u;

			[Token(Token = "0x400763A")]
			public const uint FLESH = 1153642577u;

			[Token(Token = "0x400763B")]
			public const uint GLASS = 2449969375u;

			[Token(Token = "0x400763C")]
			public const uint GRAVEL = 2185786256u;

			[Token(Token = "0x400763D")]
			public const uint ICE = 344481046u;

			[Token(Token = "0x400763E")]
			public const uint LEATHER = 3624926856u;

			[Token(Token = "0x400763F")]
			public const uint METAL = 2473969246u;

			[Token(Token = "0x4007640")]
			public const uint PLASTIC = 660835419u;

			[Token(Token = "0x4007641")]
			public const uint RUG = 712161697u;

			[Token(Token = "0x4007642")]
			public const uint SNOW = 787898836u;

			[Token(Token = "0x4007643")]
			public const uint SNOWROPE = 3468471864u;

			[Token(Token = "0x4007644")]
			public const uint STONE = 1216965916u;

			[Token(Token = "0x4007645")]
			public const uint STRAW = 1161954770u;

			[Token(Token = "0x4007646")]
			public const uint WATER = 2654748154u;

			[Token(Token = "0x4007647")]
			public const uint WOOD = 2058049674u;

			[Token(Token = "0x4007648")]
			public const uint WOODSOLID = 2219893051u;
		}

		[Token(Token = "0x4007635")]
		public const uint GROUP = 2356565362u;
	}

	[Token(Token = "0x2000B8E")]
	public static class NOISEMAKER
	{
		[Token(Token = "0x2000B8F")]
		public static class SWITCH
		{
			[Token(Token = "0x400764A")]
			public const uint DETONATED_FALSE = 4063097247u;

			[Token(Token = "0x400764B")]
			public const uint DETONATED_TRUE = 2788965598u;
		}

		[Token(Token = "0x4007649")]
		public const uint GROUP = 3389194859u;
	}

	[Token(Token = "0x2000B90")]
	public static class PLAYERGENDER
	{
		[Token(Token = "0x2000B91")]
		public static class SWITCH
		{
			[Token(Token = "0x400764D")]
			public const uint FEMALE = 2204441813u;

			[Token(Token = "0x400764E")]
			public const uint MALE = 3111576190u;
		}

		[Token(Token = "0x400764C")]
		public const uint GROUP = 3424574565u;
	}

	[Token(Token = "0x2000B92")]
	public static class SAFEHOUSEOBJECTCATEGORYSWITCH
	{
		[Token(Token = "0x2000B93")]
		public static class SWITCH
		{
			[Token(Token = "0x4007650")]
			public const uint SOC_FLOOR = 1349635757u;

			[Token(Token = "0x4007651")]
			public const uint SOC_FURNITURE = 495205229u;

			[Token(Token = "0x4007652")]
			public const uint SOC_PROPS = 1051126389u;

			[Token(Token = "0x4007653")]
			public const uint SOC_WALL = 2392680789u;
		}

		[Token(Token = "0x400764F")]
		public const uint GROUP = 3684701923u;
	}

	[Token(Token = "0x2000B94")]
	public static class STEAMPIPELEAK
	{
		[Token(Token = "0x2000B95")]
		public static class SWITCH
		{
			[Token(Token = "0x4007655")]
			public const uint STEAMPIPELEAK_OFF = 83630668u;

			[Token(Token = "0x4007656")]
			public const uint STEAMPIPELEAK_ON = 2670657382u;
		}

		[Token(Token = "0x4007654")]
		public const uint GROUP = 1475825510u;
	}

	[Token(Token = "0x2000B96")]
	public static class STEAMPIPEPRESSURELEAK
	{
		[Token(Token = "0x2000B97")]
		public static class SWITCH
		{
			[Token(Token = "0x4007658")]
			public const uint STEAMPIPEPRESSURELEAK_OFF = 2373267077u;

			[Token(Token = "0x4007659")]
			public const uint STEAMPIPEPRESSURELEAK_ON = 1471917945u;
		}

		[Token(Token = "0x4007657")]
		public const uint GROUP = 757231891u;
	}

	[Token(Token = "0x2000B98")]
	public static class SURFACETAG
	{
		[Token(Token = "0x2000B99")]
		public static class SWITCH
		{
			[Token(Token = "0x400765B")]
			public const uint ST_CLIFF = 2729452499u;

			[Token(Token = "0x400765C")]
			public const uint ST_CLOTH = 2494963121u;

			[Token(Token = "0x400765D")]
			public const uint ST_CONVEYORBELT = 3667422879u;

			[Token(Token = "0x400765E")]
			public const uint ST_DIRT = 1900036184u;

			[Token(Token = "0x400765F")]
			public const uint ST_FLESH = 1854090135u;

			[Token(Token = "0x4007660")]
			public const uint ST_GLASS = 3084008529u;

			[Token(Token = "0x4007661")]
			public const uint ST_GRAVEL = 4188888086u;

			[Token(Token = "0x4007662")]
			public const uint ST_ICE = 3887556488u;

			[Token(Token = "0x4007663")]
			public const uint ST_LEATHER = 3732915290u;

			[Token(Token = "0x4007664")]
			public const uint ST_METAL = 529384012u;

			[Token(Token = "0x4007665")]
			public const uint ST_PLASTIC = 4115801929u;

			[Token(Token = "0x4007666")]
			public const uint ST_RUG = 3517610303u;

			[Token(Token = "0x4007667")]
			public const uint ST_SNOW = 3114010414u;

			[Token(Token = "0x4007668")]
			public const uint ST_SNOWROPE = 4174452970u;

			[Token(Token = "0x4007669")]
			public const uint ST_STONE = 1430020822u;

			[Token(Token = "0x400766A")]
			public const uint ST_STRAW = 1981563532u;

			[Token(Token = "0x400766B")]
			public const uint ST_WATER = 1210496296u;

			[Token(Token = "0x400766C")]
			public const uint ST_WOOD = 89194176u;

			[Token(Token = "0x400766D")]
			public const uint ST_WOODSOLID = 3885928813u;
		}

		[Token(Token = "0x400765A")]
		public const uint GROUP = 1466184054u;
	}

	[Token(Token = "0x2000B9A")]
	public static class TEMPERATUREBLENDSWITCH
	{
		[Token(Token = "0x2000B9B")]
		public static class SWITCH
		{
			[Token(Token = "0x400766F")]
			public const uint TEMPERATURE_COLD = 876491594u;

			[Token(Token = "0x4007670")]
			public const uint TEMPERATURE_NORMAL = 3859040117u;
		}

		[Token(Token = "0x400766E")]
		public const uint GROUP = 2455016278u;
	}

	[Token(Token = "0x2000B9C")]
	public static class TOGGLESWITCH
	{
		[Token(Token = "0x2000B9D")]
		public static class SWITCH
		{
			[Token(Token = "0x4007672")]
			public const uint OFF = 930712164u;

			[Token(Token = "0x4007673")]
			public const uint ON = 1651971902u;
		}

		[Token(Token = "0x4007671")]
		public const uint GROUP = 598009201u;
	}

	[Token(Token = "0x2000B9E")]
	public static class TRADER_NEARRADIO
	{
		[Token(Token = "0x2000B9F")]
		public static class SWITCH
		{
			[Token(Token = "0x4007675")]
			public const uint TNR_FAR = 467758193u;

			[Token(Token = "0x4007676")]
			public const uint TNR_NEAR = 3565010672u;
		}

		[Token(Token = "0x4007674")]
		public const uint GROUP = 2501882927u;
	}

	[Token(Token = "0x2000BA0")]
	public static class TRADER_TRUSTLEVEL_SWITCH
	{
		[Token(Token = "0x2000BA1")]
		public static class SWITCH
		{
			[Token(Token = "0x4007678")]
			public const uint TTL_ANNOYED = 3600187904u;

			[Token(Token = "0x4007679")]
			public const uint TTL_NEUTRAL = 471108991u;

			[Token(Token = "0x400767A")]
			public const uint TTL_SATISFIED = 3683649666u;
		}

		[Token(Token = "0x4007677")]
		public const uint GROUP = 4039032503u;
	}

	[Token(Token = "0x2000BA2")]
	public static class TRAVOIS_MOVEMENTSWITCH
	{
		[Token(Token = "0x2000BA3")]
		public static class SWITCH
		{
			[Token(Token = "0x400767C")]
			public const uint TM_FALSE = 722836924u;

			[Token(Token = "0x400767D")]
			public const uint TM_TRUE = 893283523u;
		}

		[Token(Token = "0x400767B")]
		public const uint GROUP = 4008929735u;
	}

	[Token(Token = "0x2000BA4")]
	public static class TRAVOIS_TURNINGSWITCH
	{
		[Token(Token = "0x2000BA5")]
		public static class SWITCH
		{
			[Token(Token = "0x400767F")]
			public const uint TT_FALSE = 1976509953u;

			[Token(Token = "0x4007680")]
			public const uint TTTRUE = 516275841u;
		}

		[Token(Token = "0x400767E")]
		public const uint GROUP = 930749651u;
	}

	[Token(Token = "0x2000BA6")]
	public static class TRAVOIS_WEIGHTRATIOSWITCH
	{
		[Token(Token = "0x2000BA7")]
		public static class SWITCH
		{
			[Token(Token = "0x4007682")]
			public const uint TWR_HEAVY = 1831933448u;

			[Token(Token = "0x4007683")]
			public const uint TWR_LIGHT = 4191641293u;

			[Token(Token = "0x4007684")]
			public const uint TWR_MEDIUM = 687864378u;
		}

		[Token(Token = "0x4007681")]
		public const uint GROUP = 3216189381u;
	}

	[Token(Token = "0x2000BA8")]
	public static class URGENCY
	{
		[Token(Token = "0x2000BA9")]
		public static class SWITCH
		{
			[Token(Token = "0x4007686")]
			public const uint HIGH = 3550808449u;

			[Token(Token = "0x4007687")]
			public const uint LOW = 545371365u;

			[Token(Token = "0x4007688")]
			public const uint MED = 981339021u;
		}

		[Token(Token = "0x4007685")]
		public const uint GROUP = 663727950u;
	}

	[Token(Token = "0x2000BAA")]
	public static class WEAPONFIRE
	{
		[Token(Token = "0x2000BAB")]
		public static class SWITCH
		{
			[Token(Token = "0x400768A")]
			public const uint FIRE = 2678880713u;

			[Token(Token = "0x400768B")]
			public const uint MISFIRE = 961448298u;
		}

		[Token(Token = "0x4007689")]
		public const uint GROUP = 476134665u;
	}

	[Token(Token = "0x2000BAC")]
	public static class WEAPONSHELLNUMDROPPED
	{
		[Token(Token = "0x2000BAD")]
		public static class SWITCH
		{
			[Token(Token = "0x400768D")]
			public const uint SHELLNUM_01 = 3050093231u;

			[Token(Token = "0x400768E")]
			public const uint SHELLNUM_02 = 3050093228u;

			[Token(Token = "0x400768F")]
			public const uint SHELLNUM_03 = 3050093229u;

			[Token(Token = "0x4007690")]
			public const uint SHELLNUM_04 = 3050093226u;

			[Token(Token = "0x4007691")]
			public const uint SHELLNUM_05 = 3050093227u;

			[Token(Token = "0x4007692")]
			public const uint SHELLNUM_06 = 3050093224u;
		}

		[Token(Token = "0x400768C")]
		public const uint GROUP = 69961555u;
	}

	[Token(Token = "0x2000BAE")]
	public static class WEAPONTYPE
	{
		[Token(Token = "0x2000BAF")]
		public static class SWITCH
		{
			[Token(Token = "0x4007694")]
			public const uint BAREHANDS = 518763173u;

			[Token(Token = "0x4007695")]
			public const uint COUGARCLAWKNIFE = 3819735414u;

			[Token(Token = "0x4007696")]
			public const uint HAMMER = 703486095u;

			[Token(Token = "0x4007697")]
			public const uint HATCHET = 425530526u;

			[Token(Token = "0x4007698")]
			public const uint IMPROVISEDHATCHET = 3389079414u;

			[Token(Token = "0x4007699")]
			public const uint IMPROVISEDKNIFE = 1158945276u;

			[Token(Token = "0x400769A")]
			public const uint KNIFE = 3312069844u;

			[Token(Token = "0x400769B")]
			public const uint PRYBAR = 584091971u;

			[Token(Token = "0x400769C")]
			public const uint REVOLVER = 1688723084u;

			[Token(Token = "0x400769D")]
			public const uint SURVIVALKNIFE = 2570255714u;
		}

		[Token(Token = "0x4007693")]
		public const uint GROUP = 767731869u;
	}

	[Token(Token = "0x2000BB0")]
	public static class WINDINTENSITYBLENDSWITCH
	{
		[Token(Token = "0x2000BB1")]
		public static class SWITCH
		{
			[Token(Token = "0x400769F")]
			public const uint WIB_00 = 952142188u;

			[Token(Token = "0x40076A0")]
			public const uint WIB_05 = 952142185u;

			[Token(Token = "0x40076A1")]
			public const uint WIB_10 = 968919775u;

			[Token(Token = "0x40076A2")]
			public const uint WIB_15 = 968919770u;

			[Token(Token = "0x40076A3")]
			public const uint WIB_20 = 985697458u;

			[Token(Token = "0x40076A4")]
			public const uint WIB_25 = 985697463u;

			[Token(Token = "0x40076A5")]
			public const uint WIB_30 = 1002475045u;

			[Token(Token = "0x40076A6")]
			public const uint WIB_35 = 1002475040u;

			[Token(Token = "0x40076A7")]
			public const uint WIB_40 = 885031712u;

			[Token(Token = "0x40076A8")]
			public const uint WIB_45 = 885031717u;

			[Token(Token = "0x40076A9")]
			public const uint WIB_50 = 901809299u;

			[Token(Token = "0x40076AA")]
			public const uint WIB_55 = 901809302u;

			[Token(Token = "0x40076AB")]
			public const uint WIB_60 = 918586886u;

			[Token(Token = "0x40076AC")]
			public const uint WIB_65 = 918586883u;

			[Token(Token = "0x40076AD")]
			public const uint WIB_70 = 935364601u;

			[Token(Token = "0x40076AE")]
			public const uint WIB_75 = 935364604u;

			[Token(Token = "0x40076AF")]
			public const uint WIB_80 = 1086363076u;

			[Token(Token = "0x40076B0")]
			public const uint WIB_85 = 1086363073u;

			[Token(Token = "0x40076B1")]
			public const uint WIB_90 = 1103140791u;

			[Token(Token = "0x40076B2")]
			public const uint WIB_95 = 1103140786u;

			[Token(Token = "0x40076B3")]
			public const uint WIB_100 = 3373964605u;
		}

		[Token(Token = "0x400769E")]
		public const uint GROUP = 3157427267u;
	}
}
