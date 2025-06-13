using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000432 RID: 1074
	public class DeadDrop : MonoBehaviour
	{
		// Token: 0x06005C28 RID: 23592 RVA: 0x001ADD80 File Offset: 0x001ABF80
		// Note: this type is marked as 'beforefieldinit'.
		static DeadDrop()
		{
			Il2CppClassPointerStore<DeadDrop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DeadDrop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr);
			DeadDrop.NativeFieldInfoPtr_DeadDrops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDrops");
			DeadDrop.NativeFieldInfoPtr_DeadDropName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDropName");
			DeadDrop.NativeFieldInfoPtr_DeadDropDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDropDescription");
			DeadDrop.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "Storage");
			DeadDrop.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "PoI");
			DeadDrop.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "Light");
			DeadDrop.NativeFieldInfoPtr_ItemCountVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "ItemCountVariable");
			DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<GUID>k__BackingField");
			DeadDrop.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "BakedGUID");
			DeadDrop.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675106);
			DeadDrop.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675107);
			DeadDrop.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675108);
			DeadDrop.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675109);
			DeadDrop.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675110);
			DeadDrop.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675111);
			DeadDrop.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675112);
			DeadDrop.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675113);
			DeadDrop.NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675114);
			DeadDrop.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675115);
			DeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100675116);
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06005C29 RID: 23593 RVA: 0x001ADF40 File Offset: 0x001AC140
		// (set) Token: 0x06005C2A RID: 23594 RVA: 0x001ADF7C File Offset: 0x001AC17C
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x001ADFBC File Offset: 0x001AC1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194922, XrefRangeEnd = 194925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x001ADFF0 File Offset: 0x001AC1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194925, XrefRangeEnd = 194939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadDrop.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x001AE02C File Offset: 0x001AC22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194939, XrefRangeEnd = 194942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x001AE060 File Offset: 0x001AC260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194942, XrefRangeEnd = 194973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadDrop.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x001AE09C File Offset: 0x001AC29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194973, XrefRangeEnd = 194977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x001AE0DC File Offset: 0x001AC2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194977, XrefRangeEnd = 194985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x001AE110 File Offset: 0x001AC310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195036, RefRangeEnd = 195037, XrefRangeStart = 194985, XrefRangeEnd = 195036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeadDrop GetRandomEmptyDrop(Vector3 origin)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref origin;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr2) : null;
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x001AE150 File Offset: 0x001AC350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195037, XrefRangeEnd = 195049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDeadDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x001AE184 File Offset: 0x001AC384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195049, XrefRangeEnd = 195055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeadDrop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x0002B5A7 File Offset: 0x000297A7
		public DeadDrop(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06005C35 RID: 23605 RVA: 0x001AE1C0 File Offset: 0x001AC3C0
		// (set) Token: 0x06005C36 RID: 23606 RVA: 0x0002B5B0 File Offset: 0x000297B0
		public unsafe static List<DeadDrop> DeadDrops
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeadDrop.NativeFieldInfoPtr_DeadDrops, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeadDrop>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeadDrop.NativeFieldInfoPtr_DeadDrops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06005C37 RID: 23607 RVA: 0x001AE1E8 File Offset: 0x001AC3E8
		// (set) Token: 0x06005C38 RID: 23608 RVA: 0x0002B5C2 File Offset: 0x000297C2
		public unsafe string DeadDropName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06005C39 RID: 23609 RVA: 0x001AE210 File Offset: 0x001AC410
		// (set) Token: 0x06005C3A RID: 23610 RVA: 0x0002B5E1 File Offset: 0x000297E1
		public unsafe string DeadDropDescription
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06005C3B RID: 23611 RVA: 0x001AE238 File Offset: 0x001AC438
		// (set) Token: 0x06005C3C RID: 23612 RVA: 0x0002B600 File Offset: 0x00029800
		public unsafe StorageEntity Storage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Storage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06005C3D RID: 23613 RVA: 0x001AE268 File Offset: 0x001AC468
		// (set) Token: 0x06005C3E RID: 23614 RVA: 0x0002B61F File Offset: 0x0002981F
		public unsafe POI PoI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_PoI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x001AE298 File Offset: 0x001AC498
		// (set) Token: 0x06005C40 RID: 23616 RVA: 0x0002B63E File Offset: 0x0002983E
		public unsafe OptimizedLight Light
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Light);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06005C41 RID: 23617 RVA: 0x001AE2C8 File Offset: 0x001AC4C8
		// (set) Token: 0x06005C42 RID: 23618 RVA: 0x0002B65D File Offset: 0x0002985D
		public unsafe string ItemCountVariable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_ItemCountVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_ItemCountVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06005C43 RID: 23619 RVA: 0x001AE2F0 File Offset: 0x001AC4F0
		// (set) Token: 0x06005C44 RID: 23620 RVA: 0x0002B67C File Offset: 0x0002987C
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06005C45 RID: 23621 RVA: 0x001AE318 File Offset: 0x001AC518
		// (set) Token: 0x06005C46 RID: 23622 RVA: 0x0002B697 File Offset: 0x00029897
		public unsafe string BakedGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003EE7 RID: 16103
		private static readonly System.IntPtr NativeFieldInfoPtr_DeadDrops;

		// Token: 0x04003EE8 RID: 16104
		private static readonly System.IntPtr NativeFieldInfoPtr_DeadDropName;

		// Token: 0x04003EE9 RID: 16105
		private static readonly System.IntPtr NativeFieldInfoPtr_DeadDropDescription;

		// Token: 0x04003EEA RID: 16106
		private static readonly System.IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04003EEB RID: 16107
		private static readonly System.IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003EEC RID: 16108
		private static readonly System.IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04003EED RID: 16109
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemCountVariable;

		// Token: 0x04003EEE RID: 16110
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003EEF RID: 16111
		private static readonly System.IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04003EF0 RID: 16112
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003EF1 RID: 16113
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003EF2 RID: 16114
		private static readonly System.IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04003EF3 RID: 16115
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003EF4 RID: 16116
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003EF5 RID: 16117
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003EF6 RID: 16118
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003EF7 RID: 16119
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04003EF8 RID: 16120
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0;

		// Token: 0x04003EF9 RID: 16121
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0;

		// Token: 0x04003EFA RID: 16122
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A2F RID: 2607
		[ObfuscatedName("ScheduleOne.Economy.DeadDrop+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D265 RID: 53861 RVA: 0x0032CE80 File Offset: 0x0032B080
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr);
				DeadDrop.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, "<>9");
				DeadDrop.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, "<>9__18_0");
				DeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, 100675119);
				DeadDrop.__c.NativeMethodInfoPtr__GetRandomEmptyDrop_b__18_0_Internal_Boolean_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, 100675120);
			}

			// Token: 0x0600D266 RID: 53862 RVA: 0x0032CEFC File Offset: 0x0032B0FC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D267 RID: 53863 RVA: 0x0032CF38 File Offset: 0x0032B138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194916, XrefRangeEnd = 194917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomEmptyDrop_b__18_0(DeadDrop drop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drop);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c.NativeMethodInfoPtr__GetRandomEmptyDrop_b__18_0_Internal_Boolean_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D268 RID: 53864 RVA: 0x0006604E File Offset: 0x0006424E
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700412F RID: 16687
			// (get) Token: 0x0600D269 RID: 53865 RVA: 0x0032CF88 File Offset: 0x0032B188
			// (set) Token: 0x0600D26A RID: 53866 RVA: 0x00066057 File Offset: 0x00064257
			public unsafe static DeadDrop.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeadDrop.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeadDrop.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004130 RID: 16688
			// (get) Token: 0x0600D26B RID: 53867 RVA: 0x0032CFB0 File Offset: 0x0032B1B0
			// (set) Token: 0x0600D26C RID: 53868 RVA: 0x00066069 File Offset: 0x00064269
			public unsafe static Il2CppSystem.Func<DeadDrop, bool> __9__18_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeadDrop.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<DeadDrop, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeadDrop.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E33 RID: 36403
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E34 RID: 36404
			private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04008E35 RID: 36405
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E36 RID: 36406
			private static readonly System.IntPtr NativeMethodInfoPtr__GetRandomEmptyDrop_b__18_0_Internal_Boolean_DeadDrop_0;
		}

		// Token: 0x02000A30 RID: 2608
		[ObfuscatedName("ScheduleOne.Economy.DeadDrop+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D26D RID: 53869 RVA: 0x0032CFD8 File Offset: 0x0032B1D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr);
				DeadDrop.__c__DisplayClass18_0.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr, "origin");
				DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr, 100675121);
				DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr, 100675122);
			}

			// Token: 0x0600D26E RID: 53870 RVA: 0x0032D040 File Offset: 0x0032B240
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D26F RID: 53871 RVA: 0x0032D07C File Offset: 0x0032B27C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194917, XrefRangeEnd = 194922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetRandomEmptyDrop_b__1(DeadDrop drop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drop);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D270 RID: 53872 RVA: 0x0006607B File Offset: 0x0006427B
			public __c__DisplayClass18_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004131 RID: 16689
			// (get) Token: 0x0600D271 RID: 53873 RVA: 0x0032D0CC File Offset: 0x0032B2CC
			// (set) Token: 0x0600D272 RID: 53874 RVA: 0x00066084 File Offset: 0x00064284
			public unsafe Vector3 origin
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.__c__DisplayClass18_0.NativeFieldInfoPtr_origin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.__c__DisplayClass18_0.NativeFieldInfoPtr_origin)) = value;
				}
			}

			// Token: 0x04008E37 RID: 36407
			private static readonly System.IntPtr NativeFieldInfoPtr_origin;

			// Token: 0x04008E38 RID: 36408
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E39 RID: 36409
			private static readonly System.IntPtr NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0;
		}
	}
}
