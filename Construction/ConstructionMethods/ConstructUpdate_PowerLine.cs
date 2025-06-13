using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property.Utilities.Power;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020004B0 RID: 1200
	public class ConstructUpdate_PowerLine : ConstructUpdate_Base
	{
		// Token: 0x060066D3 RID: 26323 RVA: 0x001D2630 File Offset: 0x001D0830
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_PowerLine()
		{
			Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_PowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr);
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_ghostPowerLine_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "ghostPowerLine_Material");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_cosmeticPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "cosmeticPowerNode");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempPowerLineContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "tempPowerLineContainer");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_hoveredPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "hoveredPowerNode");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "tempSegments");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_startNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "startNode");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_powerLineInitialDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "powerLineInitialDistance");
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676414);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676415);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676416);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676417);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676418);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676419);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676420);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676421);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676422);
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x001D27A0 File Offset: 0x001D09A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209354, XrefRangeEnd = 209406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerLine.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x001D27DC File Offset: 0x001D09DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209406, XrefRangeEnd = 209423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructionStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerLine.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x001D2818 File Offset: 0x001D0A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209423, XrefRangeEnd = 209429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x001D285C File Offset: 0x001D0A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209429, XrefRangeEnd = 209464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerLine.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x001D2898 File Offset: 0x001D0A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209464, XrefRangeEnd = 209555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x001D28D4 File Offset: 0x001D0AD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209575, RefRangeEnd = 209578, XrefRangeStart = 209555, XrefRangeEnd = 209575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode GetHoveredPowerNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x001D2914 File Offset: 0x001D0B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209628, RefRangeEnd = 209629, XrefRangeStart = 209578, XrefRangeEnd = 209628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompletePowerLine(PowerNode target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x001D2958 File Offset: 0x001D0B58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209637, RefRangeEnd = 209639, XrefRangeStart = 209629, XrefRangeEnd = 209637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCreatingPowerLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x001D298C File Offset: 0x001D0B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209639, XrefRangeEnd = 209647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_PowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x0003061D File Offset: 0x0002E81D
		public ConstructUpdate_PowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x060066DE RID: 26334 RVA: 0x001D29C8 File Offset: 0x001D0BC8
		// (set) Token: 0x060066DF RID: 26335 RVA: 0x00030626 File Offset: 0x0002E826
		public unsafe Material ghostPowerLine_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_ghostPowerLine_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_ghostPowerLine_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x060066E0 RID: 26336 RVA: 0x001D29F8 File Offset: 0x001D0BF8
		// (set) Token: 0x060066E1 RID: 26337 RVA: 0x00030645 File Offset: 0x0002E845
		public unsafe GameObject cosmeticPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_cosmeticPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_cosmeticPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x001D2A28 File Offset: 0x001D0C28
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x00030664 File Offset: 0x0002E864
		public unsafe Transform tempPowerLineContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempPowerLineContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempPowerLineContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x001D2A58 File Offset: 0x001D0C58
		// (set) Token: 0x060066E5 RID: 26341 RVA: 0x00030683 File Offset: 0x0002E883
		public unsafe PowerNode hoveredPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_hoveredPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_hoveredPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x060066E6 RID: 26342 RVA: 0x001D2A88 File Offset: 0x001D0C88
		// (set) Token: 0x060066E7 RID: 26343 RVA: 0x000306A2 File Offset: 0x0002E8A2
		public unsafe List<Transform> tempSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempSegments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempSegments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x001D2AB8 File Offset: 0x001D0CB8
		// (set) Token: 0x060066E9 RID: 26345 RVA: 0x000306C1 File Offset: 0x0002E8C1
		public unsafe PowerNode startNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_startNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_startNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x060066EA RID: 26346 RVA: 0x001D2AE8 File Offset: 0x001D0CE8
		// (set) Token: 0x060066EB RID: 26347 RVA: 0x000306E0 File Offset: 0x0002E8E0
		public unsafe float powerLineInitialDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_powerLineInitialDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_powerLineInitialDistance)) = value;
			}
		}

		// Token: 0x04004629 RID: 17961
		private static readonly IntPtr NativeFieldInfoPtr_ghostPowerLine_Material;

		// Token: 0x0400462A RID: 17962
		private static readonly IntPtr NativeFieldInfoPtr_cosmeticPowerNode;

		// Token: 0x0400462B RID: 17963
		private static readonly IntPtr NativeFieldInfoPtr_tempPowerLineContainer;

		// Token: 0x0400462C RID: 17964
		private static readonly IntPtr NativeFieldInfoPtr_hoveredPowerNode;

		// Token: 0x0400462D RID: 17965
		private static readonly IntPtr NativeFieldInfoPtr_tempSegments;

		// Token: 0x0400462E RID: 17966
		private static readonly IntPtr NativeFieldInfoPtr_startNode;

		// Token: 0x0400462F RID: 17967
		private static readonly IntPtr NativeFieldInfoPtr_powerLineInitialDistance;

		// Token: 0x04004630 RID: 17968
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004631 RID: 17969
		private static readonly IntPtr NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0;

		// Token: 0x04004632 RID: 17970
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04004633 RID: 17971
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004634 RID: 17972
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04004635 RID: 17973
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0;

		// Token: 0x04004636 RID: 17974
		private static readonly IntPtr NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0;

		// Token: 0x04004637 RID: 17975
		private static readonly IntPtr NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0;

		// Token: 0x04004638 RID: 17976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
