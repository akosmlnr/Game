using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200024F RID: 591
	public class BotanistLoader : EmployeeLoader
	{
		// Token: 0x06002EFF RID: 12031 RVA: 0x0010919C File Offset: 0x0010739C
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistLoader()
		{
			Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BotanistLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr);
			BotanistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, 100668749);
			BotanistLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, 100668750);
			BotanistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, 100668751);
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x00109208 File Offset: 0x00107408
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132501, XrefRangeEnd = 132508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x0010924C File Offset: 0x0010744C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132509, RefRangeEnd = 132510, XrefRangeStart = 132508, XrefRangeEnd = 132509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00109288 File Offset: 0x00107488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132510, XrefRangeEnd = 132555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00018E5E File Offset: 0x0001705E
		public BotanistLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F22 RID: 7970
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F24 RID: 7972
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x02000935 RID: 2357
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.BotanistLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9F4 RID: 51700 RVA: 0x0031485C File Offset: 0x00312A5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr);
				BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, "botanist");
				BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, "data");
				BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668752);
				BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668753);
				BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668754);
			}

			// Token: 0x0600C9F5 RID: 51701 RVA: 0x00314900 File Offset: 0x00312B00
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9F6 RID: 51702 RVA: 0x0031493C File Offset: 0x00312B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132470, XrefRangeEnd = 132488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9F7 RID: 51703 RVA: 0x00314970 File Offset: 0x00312B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132488, XrefRangeEnd = 132501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9F8 RID: 51704 RVA: 0x00061EBA File Offset: 0x000600BA
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB7 RID: 16055
			// (get) Token: 0x0600C9F9 RID: 51705 RVA: 0x003149A4 File Offset: 0x00312BA4
			// (set) Token: 0x0600C9FA RID: 51706 RVA: 0x00061EC3 File Offset: 0x000600C3
			public unsafe Botanist botanist
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB8 RID: 16056
			// (get) Token: 0x0600C9FB RID: 51707 RVA: 0x003149D4 File Offset: 0x00312BD4
			// (set) Token: 0x0600C9FC RID: 51708 RVA: 0x00061EE2 File Offset: 0x000600E2
			public unsafe BotanistConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB9 RID: 16057
			// (get) Token: 0x0600C9FD RID: 51709 RVA: 0x00314A04 File Offset: 0x00312C04
			// (set) Token: 0x0600C9FE RID: 51710 RVA: 0x00061F01 File Offset: 0x00060101
			public unsafe BotanistData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088FE RID: 35070
			private static readonly System.IntPtr NativeFieldInfoPtr_botanist;

			// Token: 0x040088FF RID: 35071
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008900 RID: 35072
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008901 RID: 35073
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008902 RID: 35074
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008903 RID: 35075
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}
	}
}
