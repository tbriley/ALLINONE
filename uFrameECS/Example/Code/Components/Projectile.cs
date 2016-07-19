// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSExample {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.Components;
    using uFrame.Json;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(11)]
    [uFrame.Attributes.uFrameIdentifier("393180c5-b57b-44cf-b77f-abb232a63060")]
    public partial class Projectile : uFrame.ECS.Components.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Single _Speed;
        
        [UnityEngine.SerializeField()]
        private Vector3 _Direction;
        
        private Subject<PropertyChangedEvent<Single>> _SpeedObservable;
        
        private PropertyChangedEvent<Single> _SpeedEvent;
        
        private Subject<PropertyChangedEvent<Vector3>> _DirectionObservable;
        
        private PropertyChangedEvent<Vector3> _DirectionEvent;
        
        public override int ComponentId {
            get {
                return 11;
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> SpeedObservable {
            get {
                return _SpeedObservable ?? (_SpeedObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Vector3>> DirectionObservable {
            get {
                return _DirectionObservable ?? (_DirectionObservable = new Subject<PropertyChangedEvent<Vector3>>());
            }
        }
        
        public Single Speed {
            get {
                return _Speed;
            }
            set {
                SetSpeed(value);
            }
        }
        
        public Vector3 Direction {
            get {
                return _Direction;
            }
            set {
                SetDirection(value);
            }
        }
        
        public virtual void SetSpeed(Single value) {
            SetProperty(ref _Speed, value, ref _SpeedEvent, _SpeedObservable);
        }
        
        public virtual void SetDirection(Vector3 value) {
            SetProperty(ref _Direction, value, ref _DirectionEvent, _DirectionObservable);
        }
    }
}