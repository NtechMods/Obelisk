using System.Collections.Generic;
using static WeaponThread.Session.EventTriggers;
using static WeaponThread.Session.RelMove.MoveType;
using static WeaponThread.Session;

namespace WeaponThread
{ // Don't edit above this line
    partial class Weapons
    {
        private AnimationDefinition MonolithSecondary => new AnimationDefinition
        {
            Emissives = new []
            {
                Emissive(
                    EmissiveName: "Emissive", 
                    Colors: new []
                    {
                        Color(red:0.1f, green: 0.1f, blue:0.1f, alpha: 1),//will transitions from one color to the next if more than one
                        Color(red:.1f, green: .2f, blue:2.5f, alpha: 1),
						Color(red:.05f, green: .1f, blue:1.25f, alpha: 1),
                        Color(red:.1f, green: .2f, blue:2.5f, alpha: 1),
						Color(red:.05f, green: .1f, blue:1.25f, alpha: 1),
                        Color(red:.1f, green: .2f, blue:2.5f, alpha: 1),
						Color(red:.05f, green: .1f, blue:1.25f, alpha: 1),
                        Color(red:.1f, green: .2f, blue:2.5f, alpha: 1),
						Color(red:.05f, green: .1f, blue:1.25f, alpha: 1),
                    }, 
                    IntensityFrom:0, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:1, 
                    CycleEmissiveParts: false,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: false,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive"
                    }),
            },
            WeaponAnimationSets = new[]
            {
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Crystal_Edge1"),
                    BarrelId = "muzzle_barrel_04", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0, StopFiringDelay: 0),//Delay before animation starts
                    Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Firing, StopFiring),
                    EventMoveSets = new Dictionary<EventTriggers, RelMove[]>
                    {
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.6, 5, -0.6), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						[StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.6, -5, 0.6), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						
                    }
                },
				
				new PartAnimationSetDef()
                {
                    SubpartId = Names("Crystal_Edge2"),
                    BarrelId = "muzzle_barrel_03", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0, StopFiringDelay: 0),//Delay before animation starts
                    Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Firing, StopFiring),
                    EventMoveSets = new Dictionary<EventTriggers, RelMove[]>
                    {
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.6, 5, 0.6), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						[StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.6, -5, -0.6), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						
                    }
                },
				
				
				new PartAnimationSetDef()
                {
                    SubpartId = Names("Crystal_Edge3"),
                    BarrelId = "muzzle_barrel_02", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0, StopFiringDelay: 0),//Delay before animation starts
                    Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Firing, StopFiring),
                    EventMoveSets = new Dictionary<EventTriggers, RelMove[]>
                    {
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.6, 5, 0.6), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						[StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.6, -5, -0.6), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						
                    }
                },
				
				new PartAnimationSetDef()
                {
                    SubpartId = Names("Crystal_Edge4"),
                    BarrelId = "muzzle_barrel_05", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0, StopFiringDelay: 0),//Delay before animation starts
                    Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Firing, StopFiring),
                    EventMoveSets = new Dictionary<EventTriggers, RelMove[]>
                    {
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.6, 5, -0.6), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						[StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.6, -5, 0.6), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						
                    }
                },
				
				
				
				new PartAnimationSetDef()
                {
                    SubpartId = Names("Crystal_Top"),
                    BarrelId = "muzzle_barrel_01", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0, StopFiringDelay: 0),//Delay before animation starts
                    Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Firing, StopFiring),
                    EventMoveSets = new Dictionary<EventTriggers, RelMove[]>
                    {
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 4, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								
                            },
						[StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, -4, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						
                    }
                },

				new PartAnimationSetDef()
                {
                    SubpartId = Names("Crystal_Bottom"),
                    BarrelId = "muzzle_barrel_01", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0, StopFiringDelay: 0),//Delay before animation starts
                    Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Firing, StopFiring),
                    EventMoveSets = new Dictionary<EventTriggers, RelMove[]>
                    {
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 2, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								
                            },
						[StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, -2, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								
                            },


							
						
					}
                },
				
				
				
            }
        };
    }
}
