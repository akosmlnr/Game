using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200037A RID: 890
	public class FootPatrolRoute : MonoBehaviour
	{
		// Token: 0x06004361 RID: 17249 RVA: 0x0015229C File Offset: 0x0015049C
		// Note: this type is marked as 'beforefieldinit'.
		static FootPatrolRoute()
		{
			Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FootPatrolRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr);
			FootPatrolRoute.NativeFieldInfoPtr_RouteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "RouteName");
			FootPatrolRoute.NativeFieldInfoPtr_PathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "PathColor");
			FootPatrolRoute.NativeFieldInfoPtr_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "Waypoints");
			FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "StartWaypointIndex");
			FootPatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671579);
			FootPatrolRoute.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671580);
			FootPatrolRoute.NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671581);
			FootPatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671582);
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x0015236C File Offset: 0x0015056C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156802, XrefRangeEnd = 156830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x001523A0 File Offset: 0x001505A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156830, XrefRangeEnd = 156841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x001523D4 File Offset: 0x001505D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWaypoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x00152408 File Offset: 0x00150608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156841, XrefRangeEnd = 156846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootPatrolRoute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x00020E7E File Offset: 0x0001F07E
		public FootPatrolRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x00152444 File Offset: 0x00150644
		// (set) Token: 0x06004368 RID: 17256 RVA: 0x00020E87 File Offset: 0x0001F087
		public unsafe string RouteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_RouteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_RouteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x0015246C File Offset: 0x0015066C
		// (set) Token: 0x0600436A RID: 17258 RVA: 0x00020EA6 File Offset: 0x0001F0A6
		public unsafe Color PathColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_PathColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_PathColor)) = value;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x0600436B RID: 17259 RVA: 0x00152494 File Offset: 0x00150694
		// (set) Token: 0x0600436C RID: 17260 RVA: 0x00020EC1 File Offset: 0x0001F0C1
		public unsafe Il2CppReferenceArray<Transform> Waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_Waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_Waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x0600436D RID: 17261 RVA: 0x001524C4 File Offset: 0x001506C4
		// (set) Token: 0x0600436E RID: 17262 RVA: 0x00020EE0 File Offset: 0x0001F0E0
		public unsafe int StartWaypointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex)) = value;
			}
		}

		// Token: 0x04002D03 RID: 11523
		private static readonly IntPtr NativeFieldInfoPtr_RouteName;

		// Token: 0x04002D04 RID: 11524
		private static readonly IntPtr NativeFieldInfoPtr_PathColor;

		// Token: 0x04002D05 RID: 11525
		private static readonly IntPtr NativeFieldInfoPtr_Waypoints;

		// Token: 0x04002D06 RID: 11526
		private static readonly IntPtr NativeFieldInfoPtr_StartWaypointIndex;

		// Token: 0x04002D07 RID: 11527
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04002D08 RID: 11528
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04002D09 RID: 11529
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0;

		// Token: 0x04002D0A RID: 11530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
