using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000446 RID: 1094
	public class DoorSensor : MonoBehaviour
	{
		// Token: 0x06005F46 RID: 24390 RVA: 0x001B9800 File Offset: 0x001B7A00
		// Note: this type is marked as 'beforefieldinit'.
		static DoorSensor()
		{
			Il2CppClassPointerStore<DoorSensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DoorSensor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr);
			DoorSensor.NativeFieldInfoPtr_ActivationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "ActivationDistance");
			DoorSensor.NativeFieldInfoPtr_DetectorSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "DetectorSide");
			DoorSensor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "Door");
			DoorSensor.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "exclude");
			DoorSensor.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "collider");
			DoorSensor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675527);
			DoorSensor.NativeMethodInfoPtr_UpdateCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675528);
			DoorSensor.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675529);
			DoorSensor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675530);
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x001B98E4 File Offset: 0x001B7AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200365, XrefRangeEnd = 200372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x001B9918 File Offset: 0x001B7B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200372, XrefRangeEnd = 200400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_UpdateCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x001B994C File Offset: 0x001B7B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200400, XrefRangeEnd = 200413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x001B9990 File Offset: 0x001B7B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200413, XrefRangeEnd = 200421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorSensor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x0002CAD2 File Offset: 0x0002ACD2
		public DoorSensor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06005F4C RID: 24396 RVA: 0x001B99CC File Offset: 0x001B7BCC
		// (set) Token: 0x06005F4D RID: 24397 RVA: 0x0002CADB File Offset: 0x0002ACDB
		public unsafe static float ActivationDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DoorSensor.NativeFieldInfoPtr_ActivationDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoorSensor.NativeFieldInfoPtr_ActivationDistance, (void*)(&value));
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06005F4E RID: 24398 RVA: 0x001B99E8 File Offset: 0x001B7BE8
		// (set) Token: 0x06005F4F RID: 24399 RVA: 0x0002CAE9 File Offset: 0x0002ACE9
		public unsafe EDoorSide DetectorSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_DetectorSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_DetectorSide)) = value;
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06005F50 RID: 24400 RVA: 0x001B9A10 File Offset: 0x001B7C10
		// (set) Token: 0x06005F51 RID: 24401 RVA: 0x0002CB04 File Offset: 0x0002AD04
		public unsafe DoorController Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06005F52 RID: 24402 RVA: 0x001B9A40 File Offset: 0x001B7C40
		// (set) Token: 0x06005F53 RID: 24403 RVA: 0x0002CB23 File Offset: 0x0002AD23
		public unsafe List<Collider> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06005F54 RID: 24404 RVA: 0x001B9A70 File Offset: 0x001B7C70
		// (set) Token: 0x06005F55 RID: 24405 RVA: 0x0002CB42 File Offset: 0x0002AD42
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004139 RID: 16697
		private static readonly IntPtr NativeFieldInfoPtr_ActivationDistance;

		// Token: 0x0400413A RID: 16698
		private static readonly IntPtr NativeFieldInfoPtr_DetectorSide;

		// Token: 0x0400413B RID: 16699
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x0400413C RID: 16700
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x0400413D RID: 16701
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x0400413E RID: 16702
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400413F RID: 16703
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollider_Private_Void_0;

		// Token: 0x04004140 RID: 16704
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04004141 RID: 16705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
