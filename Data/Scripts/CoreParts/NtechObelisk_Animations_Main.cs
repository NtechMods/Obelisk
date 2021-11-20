using System.Collections.Generic;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.AnimationDef;
using static Scripts.Structure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove.MoveType;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove;
namespace Scripts
{ // Don't edit above this line
    partial class Parts
    {
        private AnimationDef MonolithMain => new AnimationDef
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
			
			
			EventParticles = new Dictionary<PartAnimationSetDef.EventTriggers, EventParticle[]>
            {
                [PreFire] = new[]
                {
                    new EventParticle
                    {
                        EmptyNames = Names("subpart_Crystal_Top"),
						MuzzleNames = Names("muzzle_barrel_01"),
                        StartDelay = 60, //ticks 60 = 1 second
                        LoopDelay = 0, //ticks 60 = 1 second
                        Particle = new ParticleDef
                        {
                            Name = "",
                            Color = Color(red: 1.0f, green: 2.0f, blue: 25f, alpha: 1),
                            Extras = new ParticleOptionDef
                            {
                                Loop = true,
                                Restart = false,
                                MaxDistance = 200, //meters
                                MaxDuration = 180, //ticks 60 = 1 second
                                Scale = 0.8f,
                            }
                        }
                    },
				},	
				[Firing] = new[]
                {
					new EventParticle
                    {
                        EmptyNames = Names("subpart_Crystal_Top"),
						MuzzleNames = Names("muzzle_barrel_01"),
                        StartDelay = 0, //ticks 60 = 1 second
                        LoopDelay = 0, //ticks 60 = 1 second
                        Particle = new ParticleDef
                        {
                            Name = "",
                            Color = Color(red: 1.0f, green: 2.0f, blue: 25f, alpha: 1),
                            Extras = new ParticleOptionDef
                            {
                                Loop = true,
                                Restart = false,
                                MaxDistance = 200, //meters
                                MaxDuration = 180, //ticks 60 = 1 second
                                Scale = 0.7f,
                            }
                        }
                    },
					
					
					
					
                },
				
				[Firing] = new[]
                {
					new EventParticle
                    {
                        EmptyNames = Names("subpart_Crystal_Top"),
						MuzzleNames = Names("muzzle_barrel_03"),
                        StartDelay = 0, //ticks 60 = 1 second
                        LoopDelay = 0, //ticks 60 = 1 second
                        Particle = new ParticleDef
                        {
                            Name = "",
                            Color = Color(red: 1.0f, green: 2.0f, blue: 25f, alpha: 1),
                            Extras = new ParticleOptionDef
                            {
                                Loop = true,
                                Restart = false,
                                MaxDistance = 200, //meters
                                MaxDuration = 180, //ticks 60 = 1 second
                                Scale = 0.7f,
                            }
                        }
                    },
					
					
					
					
                },
				
				[Firing] = new[]
                {
					new EventParticle
                    {
                        EmptyNames = Names("subpart_Crystal_Top"),
						MuzzleNames = Names("muzzle_barrel_04"),
                        StartDelay = 0, //ticks 60 = 1 second
                        LoopDelay = 0, //ticks 60 = 1 second
                        Particle = new ParticleDef
                        {
                            Name = "",
                            Color = Color(red: 1.0f, green: 2.0f, blue: 25f, alpha: 1),
                            Extras = new ParticleOptionDef
                            {
                                Loop = true,
                                Restart = false,
                                MaxDistance = 200, //meters
                                MaxDuration = 180, //ticks 60 = 1 second
                                Scale = 0.7f,
                            }
                        }
                    },
					
					
					
					
                },
				
				[Firing] = new[]
                {
					new EventParticle
                    {
                        EmptyNames = Names("subpart_Crystal_Top"),
						MuzzleNames = Names("muzzle_barrel_05"),
                        StartDelay = 0, //ticks 60 = 1 second
                        LoopDelay = 0, //ticks 60 = 1 second
                        Particle = new ParticleDef
                        {
                            Name = "",
                            Color = Color(red: 1.0f, green: 2.0f, blue: 25f, alpha: 1),
                            Extras = new ParticleOptionDef
                            {
                                Loop = true,
                                Restart = false,
                                MaxDistance = 200, //meters
                                MaxDuration = 180, //ticks 60 = 1 second
                                Scale = 0.7f,
                            }
                        }
                    },
					
					
					
					
                },
            },
			
					
            AnimationSets = new[]
            {
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Crystal_Top"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(Firing, StopFiring), // (Firing, Overheated)
                    Loop = Events(Firing), // (Firing, Overheated)
                    TriggerOnce = Events(PreFire, StopFiring, Firing),
                    ResetEmissives = Events(StopTracking, TurnOff),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 80, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, -1.6, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },								
                            },
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 80, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 1.6, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						[Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 100, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]{
                                        Transformation(0, 0, 0)
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						
                        [StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 100, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]{
                                        Transformation(0, 0, 0)
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
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(Firing, StopFiring), // (Firing, Overheated)
                    Loop = Events(Firing), // (Firing, Overheated)
                    TriggerOnce = Events(PreFire, StopFiring, Firing),
                    ResetEmissives = Events(StopTracking, TurnOff),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 80, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0.80, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },								
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {
								
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 80, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, -0.80, 0), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 100, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]{
                                        Transformation(0, 0, 0)
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						
                        [StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 100, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]{
                                        Transformation(0, 0, 0)
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
							
						
					}
                },

				// Sheath Center Bottom

                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_1"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(),
                    Loop = Events(),
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(TurnOff, StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, -0.79, 0.30), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },

                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0.79, -0.30), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_2"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(),
                    Loop = Events(),
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(TurnOff, StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.30, -0.79, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.30, 0.79, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_3"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(),
                    Loop = Events(),
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(TurnOff, StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, -0.79, -0.30), //linear movement (x=L,R y=U,D z=F,B)
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0.79, 0.30), //linear movement (x=L,R y=U,D z=F,B)
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_4"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(),
                    Loop = Events(),
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(TurnOff, StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.30, -0.79, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.30, 0.79, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },

                    }
                },	


				// Sheath Center Top
				
				new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath2_1"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(),
                    Loop = Events(),
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(TurnOff, StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, -4.56, 0.74), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },

                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 4.56, -0.74), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath2_2"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(),
                    Loop = Events(),
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(TurnOff, StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.74, -4.56, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.74, 4.56, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath2_3"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(),
                    Loop = Events(),
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(TurnOff, StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.0, -4.56, -0.74), //linear movement (x=L,R y=U,D z=F,B)
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 4.56, 0.74), //linear movement (x=L,R y=U,D z=F,B)
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath2_4"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(),
                    Loop = Events(),
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(TurnOff, StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.74, -4.56, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.74, 4.56, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },

                    }
                },
				
				
				// Begin Corner Sheaths
				
				new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_C1"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Tracking, StopTracking, TurnOff, TurnOn),
                    ResetEmissives = Events(StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "CornerPivot",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.32, -2.4, 0.32), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "CornerPivot",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.32, 2.4, -0.32), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_C2"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.32, -2.4, -0.32), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.32, 2.4, 0.32), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_C3"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.32, -2.4, -0.32), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.32, 2.4, 0.32), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_C4"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.32, -2.4, 0.32), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.32, 2.4, -0.32), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
				
				
								// Begin Corner Sheaths
				
				new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_2C1"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Tracking, StopTracking, TurnOff, TurnOn),
                    ResetEmissives = Events(StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "CornerPivot",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.58, -5.5, 0.58), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "CornerPivot",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.58, 5.5, -0.58), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_2C2"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.58, -5.5, -0.58), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.58, 5.5, 0.58), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_2C3"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.58, -5.5, -0.58), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.58, 5.5, 0.58), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Sheath_2C4"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 60, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0, stopFiringDelay: 0),//Delay before animation starts
                     Reverse = Events(), // (Firing, Overheated)
                    Loop = Events(), // (Firing, Overheated)
                    TriggerOnce = Events(Tracking, StopTracking),
                    ResetEmissives = Events(StopTracking),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(-0.58, -5.5, 0.58), //linear movement x=L,R y=U,D z=F,B
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, NoMagsToLoad, OutOfAmmo, PreFire  EmptyOnGameLoad, StopFiring, StopTracking, LockDelay
                            {

                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 300, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoDecay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    EmissiveName = "",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0.58, 5.5, -0.58), //linear movement x=L,R y=U,D z=F,B
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
