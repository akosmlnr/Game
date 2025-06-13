using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000186 RID: 390
	public class BaseVariable : Il2CppSystem.Object
	{
		// Token: 0x06001EE6 RID: 7910 RVA: 0x000D3818 File Offset: 0x000D1A18
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVariable()
		{
			Il2CppClassPointerStore<BaseVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "BaseVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr);
			BaseVariable.NativeFieldInfoPtr_ReplicationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "ReplicationMode");
			BaseVariable.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "Name");
			BaseVariable.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "Persistent");
			BaseVariable.NativeFieldInfoPtr_VariableMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "VariableMode");
			BaseVariable.NativeFieldInfoPtr__Owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "<Owner>k__BackingField");
			BaseVariable.NativeMethodInfoPtr_get_Owner_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666834);
			BaseVariable.NativeMethodInfoPtr_set_Owner_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666835);
			BaseVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666836);
			BaseVariable.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666837);
			BaseVariable.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666838);
			BaseVariable.NativeMethodInfoPtr_ReplicateValue_Public_Abstract_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666839);
			BaseVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_New_Boolean_EConditionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666840);
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x000D3938 File Offset: 0x000D1B38
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x000D3978 File Offset: 0x000D1B78
		public unsafe Player Owner
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVariable.NativeMethodInfoPtr_get_Owner_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVariable.NativeMethodInfoPtr_set_Owner_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000D39BC File Offset: 0x000D1BBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110851, RefRangeEnd = 110853, XrefRangeStart = 110836, XrefRangeEnd = 110851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref replicationMode;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref persistent;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mode;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x000D3A44 File Offset: 0x000D1C44
		[CallerCount(0)]
		public unsafe virtual Il2CppSystem.Object GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000D3A90 File Offset: 0x000D1C90
		[CallerCount(0)]
		public unsafe virtual void SetValue(Il2CppSystem.Object value, bool replicate = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref replicate;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000D3AEC File Offset: 0x000D1CEC
		[CallerCount(0)]
		public unsafe virtual void ReplicateValue(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_ReplicateValue_Public_Abstract_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000D3B3C File Offset: 0x000D1D3C
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref operation;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_New_Boolean_EConditionType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00011519 File Offset: 0x0000F719
		public BaseVariable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x000D3BA4 File Offset: 0x000D1DA4
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x00011522 File Offset: 0x0000F722
		public unsafe EVariableReplicationMode ReplicationMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_ReplicationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_ReplicationMode)) = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x000D3BCC File Offset: 0x000D1DCC
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x0001153D File Offset: 0x0000F73D
		public unsafe string Name
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x000D3BF4 File Offset: 0x000D1DF4
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x0001155C File Offset: 0x0000F75C
		public unsafe bool Persistent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Persistent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Persistent)) = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x000D3C1C File Offset: 0x000D1E1C
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00011577 File Offset: 0x0000F777
		public unsafe EVariableMode VariableMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_VariableMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_VariableMode)) = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x000D3C44 File Offset: 0x000D1E44
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x00011592 File Offset: 0x0000F792
		public unsafe Player _Owner_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr__Owner_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr__Owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400148D RID: 5261
		private static readonly System.IntPtr NativeFieldInfoPtr_ReplicationMode;

		// Token: 0x0400148E RID: 5262
		private static readonly System.IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400148F RID: 5263
		private static readonly System.IntPtr NativeFieldInfoPtr_Persistent;

		// Token: 0x04001490 RID: 5264
		private static readonly System.IntPtr NativeFieldInfoPtr_VariableMode;

		// Token: 0x04001491 RID: 5265
		private static readonly System.IntPtr NativeFieldInfoPtr__Owner_k__BackingField;

		// Token: 0x04001492 RID: 5266
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Owner_Public_get_Player_0;

		// Token: 0x04001493 RID: 5267
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Owner_Private_set_Void_Player_0;

		// Token: 0x04001494 RID: 5268
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_0;

		// Token: 0x04001495 RID: 5269
		private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x04001496 RID: 5270
		private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Boolean_0;

		// Token: 0x04001497 RID: 5271
		private static readonly System.IntPtr NativeMethodInfoPtr_ReplicateValue_Public_Abstract_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04001498 RID: 5272
		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_New_Boolean_EConditionType_String_0;
	}
}
