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
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class ScrollSystemUpdateHandler {
        
        public BackgroundScroller Group;
        
        private uFrame.ECS.APIs.ISystemUpdate _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private UnityEngine.Vector3 ActionNode16_a = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 Vector3Node15 = new UnityEngine.Vector3(0f,0f,1f);
        
        private float ActionNode10_Result = default( System.Single );
        
        private float ActionNode18_a = default( System.Single );
        
        private float ActionNode18_b = default( System.Single );
        
        private float ActionNode18_Result = default( System.Single );
        
        private float ActionNode13_t = default( System.Single );
        
        private float ActionNode13_length = default( System.Single );
        
        private float ActionNode13_Result = default( System.Single );
        
        private float ActionNode16_b = default( System.Single );
        
        private UnityEngine.Vector3 ActionNode16_Result = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode17_a = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode17_b = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode17_Result = default( UnityEngine.Vector3 );
        
        public uFrame.ECS.APIs.ISystemUpdate Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.Systems.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode16_a = Vector3Node15;
            // ActionNode
            while (this.DebugInfo("b8958212-4f11-4c4e-86dc-afa0b2d200db","024b3184-6696-46a7-b679-792e84577234", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.TimeLibrary.GetTime
            ActionNode10_Result = uFrame.ECS.Actions.TimeLibrary.GetTime();
            ActionNode18_a = ActionNode10_Result;
            ActionNode18_b = Group.ScrollSpeed;
            // ActionNode
            while (this.DebugInfo("024b3184-6696-46a7-b679-792e84577234","39d31ab5-325e-4340-bc21-126997adc2b4", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.FloatLibrary.Multiply
            ActionNode18_Result = uFrame.ECS.Actions.FloatLibrary.Multiply(ActionNode18_a, ActionNode18_b);
            ActionNode13_t = ActionNode18_Result;
            ActionNode13_length = Group.TileSizeZ;
            // ActionNode
            while (this.DebugInfo("39d31ab5-325e-4340-bc21-126997adc2b4","8a4a4318-0daa-41a5-8832-49108a83c4d4", this) == 1) yield return null;
            // Visit UnityEngine.Mathf.Repeat
            ActionNode13_Result = UnityEngine.Mathf.Repeat(ActionNode13_t, ActionNode13_length);
            ActionNode16_b = ActionNode13_Result;
            // ActionNode
            while (this.DebugInfo("8a4a4318-0daa-41a5-8832-49108a83c4d4","00e7818f-7543-4700-9aee-d03e8f572538", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.Vector3Library.Multiply
            ActionNode16_Result = uFrame.ECS.Actions.Vector3Library.Multiply(ActionNode16_a, ActionNode16_b);
            ActionNode17_a = ActionNode16_Result;
            ActionNode17_b = Group.StartPosition;
            // ActionNode
            while (this.DebugInfo("00e7818f-7543-4700-9aee-d03e8f572538","748f3643-47bd-4590-9163-d73cc4d85341", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.Vector3Library.Add
            ActionNode17_Result = uFrame.ECS.Actions.Vector3Library.Add(ActionNode17_a, ActionNode17_b);
            // SetVariableNode
            while (this.DebugInfo("748f3643-47bd-4590-9163-d73cc4d85341","c72535ce-34bb-433a-a101-028cf29474a8", this) == 1) yield return null;
            Group.Entity.transform.position = (UnityEngine.Vector3)ActionNode17_Result;
            yield break;
        }
    }
}
