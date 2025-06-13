using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000259 RID: 601
	public class NPCLoader : DynamicLoader
	{
		// Token: 0x06002F33 RID: 12083 RVA: 0x00109ECC File Offset: 0x001080CC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCLoader()
		{
			Il2CppClassPointerStore<NPCLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "NPCLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr);
			NPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100668812);
			NPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100668813);
			NPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100668814);
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x00109F38 File Offset: 0x00108138
		public unsafe virtual string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133441, XrefRangeEnd = 133448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00109F7C File Offset: 0x0010817C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 133459, RefRangeEnd = 133472, XrefRangeStart = 133448, XrefRangeEnd = 133459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x00109FB8 File Offset: 0x001081B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133550, RefRangeEnd = 133551, XrefRangeStart = 133472, XrefRangeEnd = 133550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00018EB8 File Offset: 0x000170B8
		public NPCLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F42 RID: 8002
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0;

		// Token: 0x04001F43 RID: 8003
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F44 RID: 8004
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x02000945 RID: 2373
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.NPCLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA6F RID: 51823 RVA: 0x00315C68 File Offset: 0x00313E68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr);
				NPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_baseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr, "baseData");
				NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668815);
				NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668816);
			}

			// Token: 0x0600CA70 RID: 51824 RVA: 0x00315CD0 File Offset: 0x00313ED0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA71 RID: 51825 RVA: 0x00315D0C File Offset: 0x00313F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CA72 RID: 51826 RVA: 0x000622EC File Offset: 0x000604EC
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED5 RID: 16085
			// (get) Token: 0x0600CA73 RID: 51827 RVA: 0x00315D5C File Offset: 0x00313F5C
			// (set) Token: 0x0600CA74 RID: 51828 RVA: 0x000622F5 File Offset: 0x000604F5
			public unsafe NPCData baseData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_baseData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_baseData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400893B RID: 35131
			private static readonly System.IntPtr NativeFieldInfoPtr_baseData;

			// Token: 0x0400893C RID: 35132
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400893D RID: 35133
			private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0;
		}
	}
}
