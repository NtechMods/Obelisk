using System.Collections.Generic;
using static WeaponThread.WeaponStructure;
using static WeaponThread.WeaponStructure.WeaponDefinition;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.RelMove.MoveType;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.RelMove;
namespace WeaponThread
{ // Don't edit above this line
    partial class Weapons
    {
        private AnimationDef MonolithEdgeCrystals4 => new AnimationDef
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
                    SubpartId = Names("Crystal_Edge4"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 60, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0, StopFiringDelay: 0),//Delay before animation starts
                    Reverse = Events(Firing, StopFiring), // (Firing, Overheated)
                    Loop = Events(Firing), // (Firing, Overheated)
                    TriggerOnce = Events(PreFire, StopFiring, Firing),
                    ResetEmissives = Events(StopTracking, TurnOff),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 65, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]{
                                        Transformation(0f, 1, 0f)
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
                                    TicksToMove = 65, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, -1, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0f, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						[TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 95, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]{
                                        Transformation(-1.65, 3.6, -1.65)
                                    },
                                    Rotation = Transformation(-5, 0, 5), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						[TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 95, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(1.65, -3.6, 1.65), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(5, 0, -5), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
            }
        };
    }
}
