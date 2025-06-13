using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000255 RID: 597
	public class LegacyCleanerLoader : LegacyEmployeeLoader
	{
		// Token: 0x06002F1E RID: 12062 RVA: 0x00109974 File Offset: 0x00107B74
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyCleanerLoader()
		{
			Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LegacyCleanerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr);
			LegacyCleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, 100668787);
			LegacyCleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, 100668788);
			LegacyCleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, 100668789);
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x001099E0 File Offset: 0x00107BE0
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133017, XrefRangeEnd = 133024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyCleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00109A24 File Offset: 0x00107C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyCleanerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x00109A60 File Offset: 0x00107C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133024, XrefRangeEnd = 133104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyCleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x00018E94 File Offset: 0x00017094
		public LegacyCleanerLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F35 RID: 7989
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F36 RID: 7990
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F37 RID: 7991
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x0200093E RID: 2366
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyCleanerLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA3F RID: 51775 RVA: 0x00315494 File Offset: 0x00313694
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr);
				LegacyCleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, "cleaner");
				LegacyCleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668790);
			}

			// Token: 0x0600CA40 RID: 51776 RVA: 0x003154E8 File Offset: 0x003136E8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA41 RID: 51777 RVA: 0x00062158 File Offset: 0x00060358
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ECA RID: 16074
			// (get) Token: 0x0600CA42 RID: 51778 RVA: 0x00315524 File Offset: 0x00313724
			// (set) Token: 0x0600CA43 RID: 51779 RVA: 0x00062161 File Offset: 0x00060361
			public unsafe Cleaner cleaner
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008924 RID: 35108
			private static readonly System.IntPtr NativeFieldInfoPtr_cleaner;

			// Token: 0x04008925 RID: 35109
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200093F RID: 2367
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyCleanerLoader+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CA44 RID: 51780 RVA: 0x00315554 File Offset: 0x00313754
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr);
				LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, "configData");
				LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				LegacyCleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668791);
				LegacyCleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668792);
			}

			// Token: 0x0600CA45 RID: 51781 RVA: 0x003155D0 File Offset: 0x003137D0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA46 RID: 51782 RVA: 0x0031560C File Offset: 0x0031380C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132987, XrefRangeEnd = 133004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA47 RID: 51783 RVA: 0x00062180 File Offset: 0x00060380
			public __c__DisplayClass3_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ECB RID: 16075
			// (get) Token: 0x0600CA48 RID: 51784 RVA: 0x00315640 File Offset: 0x00313840
			// (set) Token: 0x0600CA49 RID: 51785 RVA: 0x00062189 File Offset: 0x00060389
			public unsafe CleanerConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ECC RID: 16076
			// (get) Token: 0x0600CA4A RID: 51786 RVA: 0x00315670 File Offset: 0x00313870
			// (set) Token: 0x0600CA4B RID: 51787 RVA: 0x000621A8 File Offset: 0x000603A8
			public unsafe LegacyCleanerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyCleanerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008926 RID: 35110
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008927 RID: 35111
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x04008928 RID: 35112
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008929 RID: 35113
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000940 RID: 2368
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyCleanerLoader+<>c__DisplayClass3_2")]
		public sealed class __c__DisplayClass3_2 : Il2CppSystem.Object
		{
			// Token: 0x0600CA4C RID: 51788 RVA: 0x003156A0 File Offset: 0x003138A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_2()
			{
				Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr);
				LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, "data");
				LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, "CS$<>8__locals2");
				LegacyCleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668793);
				LegacyCleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668794);
			}

			// Token: 0x0600CA4D RID: 51789 RVA: 0x0031571C File Offset: 0x0031391C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA4E RID: 51790 RVA: 0x00315758 File Offset: 0x00313958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133004, XrefRangeEnd = 133017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA4F RID: 51791 RVA: 0x000621C7 File Offset: 0x000603C7
			public __c__DisplayClass3_2(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ECD RID: 16077
			// (get) Token: 0x0600CA50 RID: 51792 RVA: 0x0031578C File Offset: 0x0031398C
			// (set) Token: 0x0600CA51 RID: 51793 RVA: 0x000621D0 File Offset: 0x000603D0
			public unsafe CleanerData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ECE RID: 16078
			// (get) Token: 0x0600CA52 RID: 51794 RVA: 0x003157BC File Offset: 0x003139BC
			// (set) Token: 0x0600CA53 RID: 51795 RVA: 0x000621EF File Offset: 0x000603EF
			public unsafe LegacyCleanerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyCleanerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400892A RID: 35114
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400892B RID: 35115
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x0400892C RID: 35116
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400892D RID: 35117
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
