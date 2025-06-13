using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000388 RID: 904
	public class VehiclePatrolRoute : MonoBehaviour
	{
		// Token: 0x06004575 RID: 17781 RVA: 0x0015955C File Offset: 0x0015775C
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolRoute()
		{
			Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "VehiclePatrolRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr);
			VehiclePatrolRoute.NativeFieldInfoPtr_RouteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "RouteName");
			VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "Waypoints");
			VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "StartWaypointIndex");
			VehiclePatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, 100671869);
			VehiclePatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, 100671870);
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x001595F0 File Offset: 0x001577F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159433, XrefRangeEnd = 159461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00159624 File Offset: 0x00157824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159461, XrefRangeEnd = 159466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolRoute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00021BBD File Offset: 0x0001FDBD
		public VehiclePatrolRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x00159660 File Offset: 0x00157860
		// (set) Token: 0x0600457A RID: 17786 RVA: 0x00021BC6 File Offset: 0x0001FDC6
		public unsafe string RouteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_RouteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_RouteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x00159688 File Offset: 0x00157888
		// (set) Token: 0x0600457C RID: 17788 RVA: 0x00021BE5 File Offset: 0x0001FDE5
		public unsafe Il2CppReferenceArray<Transform> Waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x001596B8 File Offset: 0x001578B8
		// (set) Token: 0x0600457E RID: 17790 RVA: 0x00021C04 File Offset: 0x0001FE04
		public unsafe int StartWaypointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex)) = value;
			}
		}

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeFieldInfoPtr_RouteName;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeFieldInfoPtr_Waypoints;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeFieldInfoPtr_StartWaypointIndex;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
