using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200046C RID: 1132
	[System.Serializable]
	public class VocalReactionDatabase : Il2CppSystem.Object
	{
		// Token: 0x06006195 RID: 24981 RVA: 0x001C1700 File Offset: 0x001BF900
		// Note: this type is marked as 'beforefieldinit'.
		static VocalReactionDatabase()
		{
			Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "VocalReactionDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr);
			VocalReactionDatabase.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, "Entries");
			VocalReactionDatabase.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, 100675839);
			VocalReactionDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, 100675840);
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x001C176C File Offset: 0x001BF96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203186, XrefRangeEnd = 203197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VocalReactionDatabase.Entry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VocalReactionDatabase.Entry>(intPtr2) : null;
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x001C17BC File Offset: 0x001BF9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203197, XrefRangeEnd = 203205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VocalReactionDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x0002DCE4 File Offset: 0x0002BEE4
		public VocalReactionDatabase(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06006199 RID: 24985 RVA: 0x001C17F8 File Offset: 0x001BF9F8
		// (set) Token: 0x0600619A RID: 24986 RVA: 0x0002DCED File Offset: 0x0002BEED
		public unsafe List<VocalReactionDatabase.Entry> Entries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.NativeFieldInfoPtr_Entries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VocalReactionDatabase.Entry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042B4 RID: 17076
		private static readonly System.IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040042B5 RID: 17077
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEntry_Public_Entry_String_0;

		// Token: 0x040042B6 RID: 17078
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5A RID: 2650
		[System.Serializable]
		public class Entry : Il2CppSystem.Object
		{
			// Token: 0x0600D3CA RID: 54218 RVA: 0x00330E04 File Offset: 0x0032F004
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr);
				VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, "Key");
				VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, "Reactions");
				VocalReactionDatabase.Entry.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100675841);
				VocalReactionDatabase.Entry.NativeMethodInfoPtr_GetRandomReaction_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100675842);
				VocalReactionDatabase.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100675843);
			}

			// Token: 0x1700418E RID: 16782
			// (get) Token: 0x0600D3CB RID: 54219 RVA: 0x00330E94 File Offset: 0x0032F094
			public unsafe string name
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x0600D3CC RID: 54220 RVA: 0x00330ECC File Offset: 0x0032F0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203185, XrefRangeEnd = 203186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetRandomReaction()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr_GetRandomReaction_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600D3CD RID: 54221 RVA: 0x00330F04 File Offset: 0x0032F104
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3CE RID: 54222 RVA: 0x00066AE6 File Offset: 0x00064CE6
			public Entry(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700418C RID: 16780
			// (get) Token: 0x0600D3CF RID: 54223 RVA: 0x00330F40 File Offset: 0x0032F140
			// (set) Token: 0x0600D3D0 RID: 54224 RVA: 0x00066AEF File Offset: 0x00064CEF
			public unsafe string Key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700418D RID: 16781
			// (get) Token: 0x0600D3D1 RID: 54225 RVA: 0x00330F68 File Offset: 0x0032F168
			// (set) Token: 0x0600D3D2 RID: 54226 RVA: 0x00066B0E File Offset: 0x00064D0E
			public unsafe Il2CppStringArray Reactions
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EF9 RID: 36601
			private static readonly System.IntPtr NativeFieldInfoPtr_Key;

			// Token: 0x04008EFA RID: 36602
			private static readonly System.IntPtr NativeFieldInfoPtr_Reactions;

			// Token: 0x04008EFB RID: 36603
			private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04008EFC RID: 36604
			private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomReaction_Public_String_0;

			// Token: 0x04008EFD RID: 36605
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
