using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003AA RID: 938
	public class EntityConfiguration : Il2CppSystem.Object
	{
		// Token: 0x06004892 RID: 18578 RVA: 0x00165678 File Offset: 0x00163878
		// Note: this type is marked as 'beforefieldinit'.
		static EntityConfiguration()
		{
			Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "EntityConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr);
			EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<Replicator>k__BackingField");
			EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<Configurable>k__BackingField");
			EntityConfiguration.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "Fields");
			EntityConfiguration.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "onChanged");
			EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<IsSelected>k__BackingField");
			EntityConfiguration.NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672338);
			EntityConfiguration.NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672339);
			EntityConfiguration.NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672340);
			EntityConfiguration.NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672341);
			EntityConfiguration.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672342);
			EntityConfiguration.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672343);
			EntityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672344);
			EntityConfiguration.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672345);
			EntityConfiguration.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672346);
			EntityConfiguration.NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672347);
			EntityConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672348);
			EntityConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672349);
			EntityConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672350);
			EntityConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672351);
			EntityConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672352);
			EntityConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672353);
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x0016584C File Offset: 0x00163A4C
		// (set) Token: 0x06004894 RID: 18580 RVA: 0x0016588C File Offset: 0x00163A8C
		public unsafe ConfigurationReplicator Replicator
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06004895 RID: 18581 RVA: 0x001658D0 File Offset: 0x00163AD0
		// (set) Token: 0x06004896 RID: 18582 RVA: 0x00165910 File Offset: 0x00163B10
		public unsafe IConfigurable Configurable
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06004897 RID: 18583 RVA: 0x00165954 File Offset: 0x00163B54
		// (set) Token: 0x06004898 RID: 18584 RVA: 0x00165990 File Offset: 0x00163B90
		public unsafe bool IsSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x001659D0 File Offset: 0x00163BD0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 165047, RefRangeEnd = 165059, XrefRangeStart = 165030, XrefRangeEnd = 165047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityConfiguration(ConfigurationReplicator replicator, IConfigurable configurable) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x00165A30 File Offset: 0x00163C30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130895, RefRangeEnd = 130899, XrefRangeStart = 130895, XrefRangeEnd = 130899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x00165A64 File Offset: 0x00163C64
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 165061, RefRangeEnd = 165069, XrefRangeStart = 165059, XrefRangeEnd = 165061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x00165AB8 File Offset: 0x00163CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165069, XrefRangeEnd = 165084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateAllFields(NetworkConnection conn = null, bool replicateDefaults = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref replicateDefaults;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x00165B08 File Offset: 0x00163D08
		[CallerCount(0)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x00165B44 File Offset: 0x00163D44
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x00165B80 File Offset: 0x00163D80
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 80391, RefRangeEnd = 80400, XrefRangeStart = 80391, XrefRangeEnd = 80400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x00165BBC File Offset: 0x00163DBC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 165084, RefRangeEnd = 165097, XrefRangeStart = 165084, XrefRangeEnd = 165084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x00165BF8 File Offset: 0x00163DF8
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x00165C40 File Offset: 0x00163E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165097, XrefRangeEnd = 165099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x00022FAB File Offset: 0x000211AB
		public EntityConfiguration(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x060048A4 RID: 18596 RVA: 0x00165C84 File Offset: 0x00163E84
		// (set) Token: 0x060048A5 RID: 18597 RVA: 0x00022FB4 File Offset: 0x000211B4
		public unsafe ConfigurationReplicator _Replicator_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x00165CB4 File Offset: 0x00163EB4
		// (set) Token: 0x060048A7 RID: 18599 RVA: 0x00022FD3 File Offset: 0x000211D3
		public unsafe IConfigurable _Configurable_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x00165CE4 File Offset: 0x00163EE4
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x00022FF2 File Offset: 0x000211F2
		public unsafe List<ConfigField> Fields
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_Fields);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConfigField>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x00165D14 File Offset: 0x00163F14
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x00023011 File Offset: 0x00021211
		public unsafe UnityEvent onChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_onChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x00165D44 File Offset: 0x00163F44
		// (set) Token: 0x060048AD RID: 18605 RVA: 0x00023030 File Offset: 0x00021230
		public unsafe bool _IsSelected_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x040030CC RID: 12492
		private static readonly System.IntPtr NativeFieldInfoPtr__Replicator_k__BackingField;

		// Token: 0x040030CD RID: 12493
		private static readonly System.IntPtr NativeFieldInfoPtr__Configurable_k__BackingField;

		// Token: 0x040030CE RID: 12494
		private static readonly System.IntPtr NativeFieldInfoPtr_Fields;

		// Token: 0x040030CF RID: 12495
		private static readonly System.IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x040030D0 RID: 12496
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSelected_k__BackingField;

		// Token: 0x040030D1 RID: 12497
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0;

		// Token: 0x040030D2 RID: 12498
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0;

		// Token: 0x040030D3 RID: 12499
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0;

		// Token: 0x040030D4 RID: 12500
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0;

		// Token: 0x040030D5 RID: 12501
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0;

		// Token: 0x040030D6 RID: 12502
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0;

		// Token: 0x040030D7 RID: 12503
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_0;

		// Token: 0x040030D8 RID: 12504
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeChanged_Protected_Void_0;

		// Token: 0x040030D9 RID: 12505
		private static readonly System.IntPtr NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0;

		// Token: 0x040030DA RID: 12506
		private static readonly System.IntPtr NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x040030DB RID: 12507
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x040030DC RID: 12508
		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x040030DD RID: 12509
		private static readonly System.IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0;

		// Token: 0x040030DE RID: 12510
		private static readonly System.IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0;

		// Token: 0x040030DF RID: 12511
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x040030E0 RID: 12512
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;
	}
}
