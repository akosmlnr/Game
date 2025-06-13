using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000437 RID: 1079
	public class DeliveryLocation : MonoBehaviour
	{
		// Token: 0x06005D76 RID: 23926 RVA: 0x001B3158 File Offset: 0x001B1358
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryLocation()
		{
			Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DeliveryLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr);
			DeliveryLocation.NativeFieldInfoPtr_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "LocationName");
			DeliveryLocation.NativeFieldInfoPtr_LocationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "LocationDescription");
			DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "CustomerStandPoint");
			DeliveryLocation.NativeFieldInfoPtr_TeleportPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "TeleportPoint");
			DeliveryLocation.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "PoI");
			DeliveryLocation.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "StaticGUID");
			DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "ScheduledContracts");
			DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "<GUID>k__BackingField");
			DeliveryLocation.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100675301);
			DeliveryLocation.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100675302);
			DeliveryLocation.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100675303);
			DeliveryLocation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100675304);
			DeliveryLocation.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100675305);
			DeliveryLocation.NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100675306);
			DeliveryLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100675307);
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06005D77 RID: 23927 RVA: 0x001B32B4 File Offset: 0x001B14B4
		// (set) Token: 0x06005D78 RID: 23928 RVA: 0x001B32F0 File Offset: 0x001B14F0
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x001B3330 File Offset: 0x001B1530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197790, XrefRangeEnd = 197794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x001B3370 File Offset: 0x001B1570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197794, XrefRangeEnd = 197815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x001B33A4 File Offset: 0x001B15A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x001B33D8 File Offset: 0x001B15D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryLocation.NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x001B341C File Offset: 0x001B161C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197815, XrefRangeEnd = 197830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x0002BDBE File Offset: 0x00029FBE
		public DeliveryLocation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06005D7F RID: 23935 RVA: 0x001B3458 File Offset: 0x001B1658
		// (set) Token: 0x06005D80 RID: 23936 RVA: 0x0002BDC7 File Offset: 0x00029FC7
		public unsafe string LocationName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06005D81 RID: 23937 RVA: 0x001B3480 File Offset: 0x001B1680
		// (set) Token: 0x06005D82 RID: 23938 RVA: 0x0002BDE6 File Offset: 0x00029FE6
		public unsafe string LocationDescription
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06005D83 RID: 23939 RVA: 0x001B34A8 File Offset: 0x001B16A8
		// (set) Token: 0x06005D84 RID: 23940 RVA: 0x0002BE05 File Offset: 0x0002A005
		public unsafe Transform CustomerStandPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06005D85 RID: 23941 RVA: 0x001B34D8 File Offset: 0x001B16D8
		// (set) Token: 0x06005D86 RID: 23942 RVA: 0x0002BE24 File Offset: 0x0002A024
		public unsafe Transform TeleportPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_TeleportPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_TeleportPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06005D87 RID: 23943 RVA: 0x001B3508 File Offset: 0x001B1708
		// (set) Token: 0x06005D88 RID: 23944 RVA: 0x0002BE43 File Offset: 0x0002A043
		public unsafe POI PoI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_PoI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06005D89 RID: 23945 RVA: 0x001B3538 File Offset: 0x001B1738
		// (set) Token: 0x06005D8A RID: 23946 RVA: 0x0002BE62 File Offset: 0x0002A062
		public unsafe string StaticGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06005D8B RID: 23947 RVA: 0x001B3560 File Offset: 0x001B1760
		// (set) Token: 0x06005D8C RID: 23948 RVA: 0x0002BE81 File Offset: 0x0002A081
		public unsafe List<Contract> ScheduledContracts
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06005D8D RID: 23949 RVA: 0x001B3590 File Offset: 0x001B1790
		// (set) Token: 0x06005D8E RID: 23950 RVA: 0x0002BEA0 File Offset: 0x0002A0A0
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x04003FE9 RID: 16361
		private static readonly System.IntPtr NativeFieldInfoPtr_LocationName;

		// Token: 0x04003FEA RID: 16362
		private static readonly System.IntPtr NativeFieldInfoPtr_LocationDescription;

		// Token: 0x04003FEB RID: 16363
		private static readonly System.IntPtr NativeFieldInfoPtr_CustomerStandPoint;

		// Token: 0x04003FEC RID: 16364
		private static readonly System.IntPtr NativeFieldInfoPtr_TeleportPoint;

		// Token: 0x04003FED RID: 16365
		private static readonly System.IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003FEE RID: 16366
		private static readonly System.IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x04003FEF RID: 16367
		private static readonly System.IntPtr NativeFieldInfoPtr_ScheduledContracts;

		// Token: 0x04003FF0 RID: 16368
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003FF1 RID: 16369
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003FF2 RID: 16370
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003FF3 RID: 16371
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003FF4 RID: 16372
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003FF5 RID: 16373
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003FF6 RID: 16374
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0;

		// Token: 0x04003FF7 RID: 16375
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
