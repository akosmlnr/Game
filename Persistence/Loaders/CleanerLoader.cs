using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000251 RID: 593
	public class CleanerLoader : EmployeeLoader
	{
		// Token: 0x06002F09 RID: 12041 RVA: 0x00109414 File Offset: 0x00107614
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerLoader()
		{
			Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "CleanerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr);
			CleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, 100668761);
			CleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, 100668762);
			CleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, 100668763);
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06002F0A RID: 12042 RVA: 0x00109480 File Offset: 0x00107680
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132667, XrefRangeEnd = 132674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x001094C4 File Offset: 0x001076C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132509, RefRangeEnd = 132510, XrefRangeStart = 132509, XrefRangeEnd = 132510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00109500 File Offset: 0x00107700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132674, XrefRangeEnd = 132719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x00018E70 File Offset: 0x00017070
		public CleanerLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F28 RID: 7976
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F29 RID: 7977
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F2A RID: 7978
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x02000937 RID: 2359
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.CleanerLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA0A RID: 51722 RVA: 0x00314C0C File Offset: 0x00312E0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr);
				CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, "cleaner");
				CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, "data");
				CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668764);
				CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668765);
				CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668766);
			}

			// Token: 0x0600CA0B RID: 51723 RVA: 0x00314CB0 File Offset: 0x00312EB0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA0C RID: 51724 RVA: 0x00314CEC File Offset: 0x00312EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132637, XrefRangeEnd = 132654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA0D RID: 51725 RVA: 0x00314D20 File Offset: 0x00312F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132654, XrefRangeEnd = 132667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA0E RID: 51726 RVA: 0x00061F86 File Offset: 0x00060186
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EBD RID: 16061
			// (get) Token: 0x0600CA0F RID: 51727 RVA: 0x00314D54 File Offset: 0x00312F54
			// (set) Token: 0x0600CA10 RID: 51728 RVA: 0x00061F8F File Offset: 0x0006018F
			public unsafe Cleaner cleaner
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EBE RID: 16062
			// (get) Token: 0x0600CA11 RID: 51729 RVA: 0x00314D84 File Offset: 0x00312F84
			// (set) Token: 0x0600CA12 RID: 51730 RVA: 0x00061FAE File Offset: 0x000601AE
			public unsafe CleanerConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EBF RID: 16063
			// (get) Token: 0x0600CA13 RID: 51731 RVA: 0x00314DB4 File Offset: 0x00312FB4
			// (set) Token: 0x0600CA14 RID: 51732 RVA: 0x00061FCD File Offset: 0x000601CD
			public unsafe CleanerData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400890A RID: 35082
			private static readonly System.IntPtr NativeFieldInfoPtr_cleaner;

			// Token: 0x0400890B RID: 35083
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x0400890C RID: 35084
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400890D RID: 35085
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400890E RID: 35086
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400890F RID: 35087
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}
	}
}
