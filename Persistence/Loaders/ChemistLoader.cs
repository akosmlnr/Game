using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000250 RID: 592
	public class ChemistLoader : EmployeeLoader
	{
		// Token: 0x06002F04 RID: 12036 RVA: 0x001092D8 File Offset: 0x001074D8
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistLoader()
		{
			Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ChemistLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr);
			ChemistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, 100668755);
			ChemistLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, 100668756);
			ChemistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, 100668757);
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x00109344 File Offset: 0x00107544
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132585, XrefRangeEnd = 132592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00109388 File Offset: 0x00107588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132509, RefRangeEnd = 132510, XrefRangeStart = 132509, XrefRangeEnd = 132510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x001093C4 File Offset: 0x001075C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132592, XrefRangeEnd = 132637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00018E67 File Offset: 0x00017067
		public ChemistLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F25 RID: 7973
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F26 RID: 7974
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F27 RID: 7975
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x02000936 RID: 2358
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.ChemistLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9FF RID: 51711 RVA: 0x00314A34 File Offset: 0x00312C34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr);
				ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_chemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, "chemist");
				ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, "data");
				ChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668758);
				ChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668759);
				ChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668760);
			}

			// Token: 0x0600CA00 RID: 51712 RVA: 0x00314AD8 File Offset: 0x00312CD8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA01 RID: 51713 RVA: 0x00314B14 File Offset: 0x00312D14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132555, XrefRangeEnd = 132572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA02 RID: 51714 RVA: 0x00314B48 File Offset: 0x00312D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132572, XrefRangeEnd = 132585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA03 RID: 51715 RVA: 0x00061F20 File Offset: 0x00060120
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EBA RID: 16058
			// (get) Token: 0x0600CA04 RID: 51716 RVA: 0x00314B7C File Offset: 0x00312D7C
			// (set) Token: 0x0600CA05 RID: 51717 RVA: 0x00061F29 File Offset: 0x00060129
			public unsafe Chemist chemist
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_chemist);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_chemist), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EBB RID: 16059
			// (get) Token: 0x0600CA06 RID: 51718 RVA: 0x00314BAC File Offset: 0x00312DAC
			// (set) Token: 0x0600CA07 RID: 51719 RVA: 0x00061F48 File Offset: 0x00060148
			public unsafe ChemistConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EBC RID: 16060
			// (get) Token: 0x0600CA08 RID: 51720 RVA: 0x00314BDC File Offset: 0x00312DDC
			// (set) Token: 0x0600CA09 RID: 51721 RVA: 0x00061F67 File Offset: 0x00060167
			public unsafe ChemistData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008904 RID: 35076
			private static readonly System.IntPtr NativeFieldInfoPtr_chemist;

			// Token: 0x04008905 RID: 35077
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008906 RID: 35078
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008907 RID: 35079
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008908 RID: 35080
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008909 RID: 35081
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}
	}
}
