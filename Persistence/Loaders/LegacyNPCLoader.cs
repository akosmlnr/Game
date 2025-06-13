using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000257 RID: 599
	public class LegacyNPCLoader : Loader
	{
		// Token: 0x06002F28 RID: 12072 RVA: 0x00109BEC File Offset: 0x00107DEC
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyNPCLoader()
		{
			Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LegacyNPCLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr);
			LegacyNPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, 100668798);
			LegacyNPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, 100668799);
			LegacyNPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, 100668800);
			LegacyNPCLoader.NativeMethodInfoPtr_TryLoadInventory_Protected_Void_String_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, 100668801);
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x00109C6C File Offset: 0x00107E6C
		public unsafe virtual string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133208, XrefRangeEnd = 133215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyNPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x00109CB0 File Offset: 0x00107EB0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 133122, RefRangeEnd = 133137, XrefRangeStart = 133122, XrefRangeEnd = 133137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyNPCLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyNPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00109CEC File Offset: 0x00107EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133215, XrefRangeEnd = 133324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyNPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00109D3C File Offset: 0x00107F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133329, RefRangeEnd = 133331, XrefRangeStart = 133324, XrefRangeEnd = 133329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryLoadInventory(string mainPath, NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyNPCLoader.NativeMethodInfoPtr_TryLoadInventory_Protected_Void_String_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00018EA6 File Offset: 0x000170A6
		public LegacyNPCLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F3B RID: 7995
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0;

		// Token: 0x04001F3C RID: 7996
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F3D RID: 7997
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001F3E RID: 7998
		private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadInventory_Protected_Void_String_NPC_0;

		// Token: 0x02000941 RID: 2369
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyNPCLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA54 RID: 51796 RVA: 0x003157EC File Offset: 0x003139EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr);
				LegacyNPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr, "data");
				LegacyNPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668802);
				LegacyNPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668803);
			}

			// Token: 0x0600CA55 RID: 51797 RVA: 0x00315854 File Offset: 0x00313A54
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyNPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA56 RID: 51798 RVA: 0x00315890 File Offset: 0x00313A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133206, XrefRangeEnd = 133208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LegacyNPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CA57 RID: 51799 RVA: 0x0006220E File Offset: 0x0006040E
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ECF RID: 16079
			// (get) Token: 0x0600CA58 RID: 51800 RVA: 0x003158E0 File Offset: 0x00313AE0
			// (set) Token: 0x0600CA59 RID: 51801 RVA: 0x00062217 File Offset: 0x00060417
			public unsafe NPCData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyNPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyNPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400892E RID: 35118
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400892F RID: 35119
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008930 RID: 35120
			private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0;
		}
	}
}
