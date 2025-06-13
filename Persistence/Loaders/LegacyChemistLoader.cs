using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000254 RID: 596
	public class LegacyChemistLoader : LegacyEmployeeLoader
	{
		// Token: 0x06002F19 RID: 12057 RVA: 0x00109838 File Offset: 0x00107A38
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyChemistLoader()
		{
			Il2CppClassPointerStore<LegacyChemistLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LegacyChemistLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyChemistLoader>.NativeClassPtr);
			LegacyChemistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyChemistLoader>.NativeClassPtr, 100668779);
			LegacyChemistLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyChemistLoader>.NativeClassPtr, 100668780);
			LegacyChemistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyChemistLoader>.NativeClassPtr, 100668781);
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x001098A4 File Offset: 0x00107AA4
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132900, XrefRangeEnd = 132907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyChemistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x001098E8 File Offset: 0x00107AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyChemistLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyChemistLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyChemistLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x00109924 File Offset: 0x00107B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132907, XrefRangeEnd = 132987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyChemistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00018E8B File Offset: 0x0001708B
		public LegacyChemistLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F32 RID: 7986
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F33 RID: 7987
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x0200093B RID: 2363
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyChemistLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA2A RID: 51754 RVA: 0x0031513C File Offset: 0x0031333C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyChemistLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_0>.NativeClassPtr);
				LegacyChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_chemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, "chemist");
				LegacyChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668782);
			}

			// Token: 0x0600CA2B RID: 51755 RVA: 0x00315190 File Offset: 0x00313390
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA2C RID: 51756 RVA: 0x000620A2 File Offset: 0x000602A2
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC5 RID: 16069
			// (get) Token: 0x0600CA2D RID: 51757 RVA: 0x003151CC File Offset: 0x003133CC
			// (set) Token: 0x0600CA2E RID: 51758 RVA: 0x000620AB File Offset: 0x000602AB
			public unsafe Chemist chemist
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_chemist);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_chemist), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400891A RID: 35098
			private static readonly System.IntPtr NativeFieldInfoPtr_chemist;

			// Token: 0x0400891B RID: 35099
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200093C RID: 2364
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyChemistLoader+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CA2F RID: 51759 RVA: 0x003151FC File Offset: 0x003133FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyChemistLoader>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_1>.NativeClassPtr);
				LegacyChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_1>.NativeClassPtr, "configData");
				LegacyChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				LegacyChemistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668783);
				LegacyChemistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668784);
			}

			// Token: 0x0600CA30 RID: 51760 RVA: 0x00315278 File Offset: 0x00313478
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyChemistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA31 RID: 51761 RVA: 0x003152B4 File Offset: 0x003134B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132870, XrefRangeEnd = 132887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyChemistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA32 RID: 51762 RVA: 0x000620CA File Offset: 0x000602CA
			public __c__DisplayClass3_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC6 RID: 16070
			// (get) Token: 0x0600CA33 RID: 51763 RVA: 0x003152E8 File Offset: 0x003134E8
			// (set) Token: 0x0600CA34 RID: 51764 RVA: 0x000620D3 File Offset: 0x000602D3
			public unsafe ChemistConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC7 RID: 16071
			// (get) Token: 0x0600CA35 RID: 51765 RVA: 0x00315318 File Offset: 0x00313518
			// (set) Token: 0x0600CA36 RID: 51766 RVA: 0x000620F2 File Offset: 0x000602F2
			public unsafe LegacyChemistLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyChemistLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400891C RID: 35100
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x0400891D RID: 35101
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x0400891E RID: 35102
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400891F RID: 35103
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x0200093D RID: 2365
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyChemistLoader+<>c__DisplayClass3_2")]
		public sealed class __c__DisplayClass3_2 : Il2CppSystem.Object
		{
			// Token: 0x0600CA37 RID: 51767 RVA: 0x00315348 File Offset: 0x00313548
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_2()
			{
				Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyChemistLoader>.NativeClassPtr, "<>c__DisplayClass3_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_2>.NativeClassPtr);
				LegacyChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_2>.NativeClassPtr, "data");
				LegacyChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_2>.NativeClassPtr, "CS$<>8__locals2");
				LegacyChemistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668785);
				LegacyChemistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668786);
			}

			// Token: 0x0600CA38 RID: 51768 RVA: 0x003153C4 File Offset: 0x003135C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyChemistLoader.__c__DisplayClass3_2>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyChemistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA39 RID: 51769 RVA: 0x00315400 File Offset: 0x00313600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132887, XrefRangeEnd = 132900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyChemistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA3A RID: 51770 RVA: 0x00062111 File Offset: 0x00060311
			public __c__DisplayClass3_2(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC8 RID: 16072
			// (get) Token: 0x0600CA3B RID: 51771 RVA: 0x00315434 File Offset: 0x00313634
			// (set) Token: 0x0600CA3C RID: 51772 RVA: 0x0006211A File Offset: 0x0006031A
			public unsafe ChemistData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC9 RID: 16073
			// (get) Token: 0x0600CA3D RID: 51773 RVA: 0x00315464 File Offset: 0x00313664
			// (set) Token: 0x0600CA3E RID: 51774 RVA: 0x00062139 File Offset: 0x00060339
			public unsafe LegacyChemistLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyChemistLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008920 RID: 35104
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008921 RID: 35105
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x04008922 RID: 35106
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008923 RID: 35107
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
