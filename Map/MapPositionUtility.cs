using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007A9 RID: 1961
	public class MapPositionUtility : Singleton<MapPositionUtility>
	{
		// Token: 0x0600B99C RID: 47516 RVA: 0x002E4C18 File Offset: 0x002E2E18
		// Note: this type is marked as 'beforefieldinit'.
		static MapPositionUtility()
		{
			Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MapPositionUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr);
			MapPositionUtility.NativeFieldInfoPtr_OriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "OriginPoint");
			MapPositionUtility.NativeFieldInfoPtr_EdgePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "EdgePoint");
			MapPositionUtility.NativeFieldInfoPtr_MapDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "MapDimensions");
			MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "<conversionFactor>k__BackingField");
			MapPositionUtility.NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100686262);
			MapPositionUtility.NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100686263);
			MapPositionUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100686264);
			MapPositionUtility.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100686265);
			MapPositionUtility.NativeMethodInfoPtr_Recalculate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100686266);
			MapPositionUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100686267);
		}

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x0600B99D RID: 47517 RVA: 0x002E4D10 File Offset: 0x002E2F10
		// (set) Token: 0x0600B99E RID: 47518 RVA: 0x002E4D4C File Offset: 0x002E2F4C
		public unsafe float conversionFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x002E4D8C File Offset: 0x002E2F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316475, XrefRangeEnd = 316485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapPositionUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9A0 RID: 47520 RVA: 0x002E4DC8 File Offset: 0x002E2FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316485, XrefRangeEnd = 316487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetMapPosition(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B9A1 RID: 47521 RVA: 0x002E4E14 File Offset: 0x002E3014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316487, XrefRangeEnd = 316494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recalculate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_Recalculate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x002E4E48 File Offset: 0x002E3048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316494, XrefRangeEnd = 316497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapPositionUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x0005ABC0 File Offset: 0x00058DC0
		public MapPositionUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x0600B9A4 RID: 47524 RVA: 0x002E4E84 File Offset: 0x002E3084
		// (set) Token: 0x0600B9A5 RID: 47525 RVA: 0x0005ABC9 File Offset: 0x00058DC9
		public unsafe Transform OriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_OriginPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_OriginPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x0600B9A6 RID: 47526 RVA: 0x002E4EB4 File Offset: 0x002E30B4
		// (set) Token: 0x0600B9A7 RID: 47527 RVA: 0x0005ABE8 File Offset: 0x00058DE8
		public unsafe Transform EdgePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_EdgePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_EdgePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x0600B9A8 RID: 47528 RVA: 0x002E4EE4 File Offset: 0x002E30E4
		// (set) Token: 0x0600B9A9 RID: 47529 RVA: 0x0005AC07 File Offset: 0x00058E07
		public unsafe float MapDimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_MapDimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_MapDimensions)) = value;
			}
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x0600B9AA RID: 47530 RVA: 0x002E4F0C File Offset: 0x002E310C
		// (set) Token: 0x0600B9AB RID: 47531 RVA: 0x0005AC22 File Offset: 0x00058E22
		public unsafe float _conversionFactor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField)) = value;
			}
		}

		// Token: 0x04007D36 RID: 32054
		private static readonly IntPtr NativeFieldInfoPtr_OriginPoint;

		// Token: 0x04007D37 RID: 32055
		private static readonly IntPtr NativeFieldInfoPtr_EdgePoint;

		// Token: 0x04007D38 RID: 32056
		private static readonly IntPtr NativeFieldInfoPtr_MapDimensions;

		// Token: 0x04007D39 RID: 32057
		private static readonly IntPtr NativeFieldInfoPtr__conversionFactor_k__BackingField;

		// Token: 0x04007D3A RID: 32058
		private static readonly IntPtr NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0;

		// Token: 0x04007D3B RID: 32059
		private static readonly IntPtr NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0;

		// Token: 0x04007D3C RID: 32060
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007D3D RID: 32061
		private static readonly IntPtr NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0;

		// Token: 0x04007D3E RID: 32062
		private static readonly IntPtr NativeMethodInfoPtr_Recalculate_Public_Void_0;

		// Token: 0x04007D3F RID: 32063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
