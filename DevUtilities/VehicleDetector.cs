using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200048F RID: 1167
	public class VehicleDetector : MonoBehaviour
	{
		// Token: 0x060063F7 RID: 25591 RVA: 0x001C8D88 File Offset: 0x001C6F88
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleDetector()
		{
			Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "VehicleDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr);
			VehicleDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "ACTIVATION_DISTANCE_SQ");
			VehicleDetector.NativeFieldInfoPtr_vehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "vehicles");
			VehicleDetector.NativeFieldInfoPtr_closestVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "closestVehicle");
			VehicleDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "<IgnoreNewDetections>k__BackingField");
			VehicleDetector.NativeFieldInfoPtr_ignoreExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "ignoreExit");
			VehicleDetector.NativeFieldInfoPtr_detectionColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "detectionColliders");
			VehicleDetector.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "collidersEnabled");
			VehicleDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676084);
			VehicleDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676085);
			VehicleDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676086);
			VehicleDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676087);
			VehicleDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676088);
			VehicleDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676089);
			VehicleDetector.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676090);
			VehicleDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676091);
			VehicleDetector.NativeMethodInfoPtr_SortVehicles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676092);
			VehicleDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676093);
			VehicleDetector.NativeMethodInfoPtr_AreAnyVehiclesOccupied_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676094);
			VehicleDetector.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676095);
			VehicleDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676096);
			VehicleDetector.NativeMethodInfoPtr__SortVehicles_b__16_0_Private_Single_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100676097);
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x060063F8 RID: 25592 RVA: 0x001C8F5C File Offset: 0x001C715C
		// (set) Token: 0x060063F9 RID: 25593 RVA: 0x001C8F98 File Offset: 0x001C7198
		public unsafe bool IgnoreNewDetections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x001C8FD8 File Offset: 0x001C71D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206197, XrefRangeEnd = 206214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x001C900C File Offset: 0x001C720C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206214, XrefRangeEnd = 206232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x001C9040 File Offset: 0x001C7240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206232, XrefRangeEnd = 206250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x001C9074 File Offset: 0x001C7274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206250, XrefRangeEnd = 206267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x001C90B8 File Offset: 0x001C72B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206267, XrefRangeEnd = 206285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x001C90EC File Offset: 0x001C72EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206285, XrefRangeEnd = 206302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x001C9130 File Offset: 0x001C7330
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 206318, RefRangeEnd = 206322, XrefRangeStart = 206302, XrefRangeEnd = 206318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortVehicles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_SortVehicles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x001C9164 File Offset: 0x001C7364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206329, RefRangeEnd = 206331, XrefRangeStart = 206322, XrefRangeEnd = 206329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnoreNewCollisions(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x001C91A4 File Offset: 0x001C73A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206336, RefRangeEnd = 206338, XrefRangeStart = 206331, XrefRangeEnd = 206336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyVehiclesOccupied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_AreAnyVehiclesOccupied_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x001C91E0 File Offset: 0x001C73E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206338, XrefRangeEnd = 206342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x001C9214 File Offset: 0x001C7414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206342, XrefRangeEnd = 206350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x001C9250 File Offset: 0x001C7450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206350, XrefRangeEnd = 206359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _SortVehicles_b__16_0(LandVehicle x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr__SortVehicles_b__16_0_Private_Single_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x0002EFFA File Offset: 0x0002D1FA
		public VehicleDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06006407 RID: 25607 RVA: 0x001C92A0 File Offset: 0x001C74A0
		// (set) Token: 0x06006408 RID: 25608 RVA: 0x0002F003 File Offset: 0x0002D203
		public unsafe static float ACTIVATION_DISTANCE_SQ
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&value));
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06006409 RID: 25609 RVA: 0x001C92BC File Offset: 0x001C74BC
		// (set) Token: 0x0600640A RID: 25610 RVA: 0x0002F011 File Offset: 0x0002D211
		public unsafe List<LandVehicle> vehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_vehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_vehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x0600640B RID: 25611 RVA: 0x001C92EC File Offset: 0x001C74EC
		// (set) Token: 0x0600640C RID: 25612 RVA: 0x0002F030 File Offset: 0x0002D230
		public unsafe LandVehicle closestVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_closestVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_closestVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600640D RID: 25613 RVA: 0x001C931C File Offset: 0x001C751C
		// (set) Token: 0x0600640E RID: 25614 RVA: 0x0002F04F File Offset: 0x0002D24F
		public unsafe bool _IgnoreNewDetections_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600640F RID: 25615 RVA: 0x001C9344 File Offset: 0x001C7544
		// (set) Token: 0x06006410 RID: 25616 RVA: 0x0002F06A File Offset: 0x0002D26A
		public unsafe bool ignoreExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_ignoreExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_ignoreExit)) = value;
			}
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x06006411 RID: 25617 RVA: 0x001C936C File Offset: 0x001C756C
		// (set) Token: 0x06006412 RID: 25618 RVA: 0x0002F085 File Offset: 0x0002D285
		public unsafe Il2CppReferenceArray<Collider> detectionColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_detectionColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_detectionColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06006413 RID: 25619 RVA: 0x001C939C File Offset: 0x001C759C
		// (set) Token: 0x06006414 RID: 25620 RVA: 0x0002F0A4 File Offset: 0x0002D2A4
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x0400442D RID: 17453
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ;

		// Token: 0x0400442E RID: 17454
		private static readonly IntPtr NativeFieldInfoPtr_vehicles;

		// Token: 0x0400442F RID: 17455
		private static readonly IntPtr NativeFieldInfoPtr_closestVehicle;

		// Token: 0x04004430 RID: 17456
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField;

		// Token: 0x04004431 RID: 17457
		private static readonly IntPtr NativeFieldInfoPtr_ignoreExit;

		// Token: 0x04004432 RID: 17458
		private static readonly IntPtr NativeFieldInfoPtr_detectionColliders;

		// Token: 0x04004433 RID: 17459
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04004434 RID: 17460
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0;

		// Token: 0x04004435 RID: 17461
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0;

		// Token: 0x04004436 RID: 17462
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004437 RID: 17463
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004438 RID: 17464
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004439 RID: 17465
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x0400443A RID: 17466
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400443B RID: 17467
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x0400443C RID: 17468
		private static readonly IntPtr NativeMethodInfoPtr_SortVehicles_Private_Void_0;

		// Token: 0x0400443D RID: 17469
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0;

		// Token: 0x0400443E RID: 17470
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyVehiclesOccupied_Public_Boolean_0;

		// Token: 0x0400443F RID: 17471
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04004440 RID: 17472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004441 RID: 17473
		private static readonly IntPtr NativeMethodInfoPtr__SortVehicles_b__16_0_Private_Single_LandVehicle_0;
	}
}
