using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000464 RID: 1124
	public class DialogueModule : MonoBehaviour
	{
		// Token: 0x06006144 RID: 24900 RVA: 0x001C08DC File Offset: 0x001BEADC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueModule()
		{
			Il2CppClassPointerStore<DialogueModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr);
			DialogueModule.NativeFieldInfoPtr_ModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "ModuleType");
			DialogueModule.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "Entries");
			DialogueModule.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675806);
			DialogueModule.NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675807);
			DialogueModule.NativeMethodInfoPtr_HasChain_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675808);
			DialogueModule.NativeMethodInfoPtr_GetLine_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675809);
			DialogueModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675810);
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x001C0998 File Offset: 0x001BEB98
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 203009, RefRangeEnd = 203015, XrefRangeStart = 202995, XrefRangeEnd = 203009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return new Entry(pointer);
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x001C09E0 File Offset: 0x001BEBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203015, XrefRangeEnd = 203024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetChain(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr2) : null;
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x001C0A30 File Offset: 0x001BEC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203024, XrefRangeEnd = 203025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChain(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_HasChain_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x001C0A80 File Offset: 0x001BEC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203025, XrefRangeEnd = 203030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLine(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetLine_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x001C0AC8 File Offset: 0x001BECC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203030, XrefRangeEnd = 203038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		public DialogueModule(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x0600614B RID: 24907 RVA: 0x001C0B04 File Offset: 0x001BED04
		// (set) Token: 0x0600614C RID: 24908 RVA: 0x0002D9F9 File Offset: 0x0002BBF9
		public unsafe EDialogueModule ModuleType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_ModuleType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_ModuleType)) = value;
			}
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x0600614D RID: 24909 RVA: 0x001C0B2C File Offset: 0x001BED2C
		// (set) Token: 0x0600614E RID: 24910 RVA: 0x0002DA14 File Offset: 0x0002BC14
		public unsafe List<Entry> Entries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_Entries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004280 RID: 17024
		private static readonly System.IntPtr NativeFieldInfoPtr_ModuleType;

		// Token: 0x04004281 RID: 17025
		private static readonly System.IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04004282 RID: 17026
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEntry_Public_Entry_String_0;

		// Token: 0x04004283 RID: 17027
		private static readonly System.IntPtr NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0;

		// Token: 0x04004284 RID: 17028
		private static readonly System.IntPtr NativeMethodInfoPtr_HasChain_Public_Boolean_String_0;

		// Token: 0x04004285 RID: 17029
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLine_Public_String_String_0;

		// Token: 0x04004286 RID: 17030
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A54 RID: 2644
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueModule+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3A6 RID: 54182 RVA: 0x00330758 File Offset: 0x0032E958
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, "key");
				DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, 100675811);
				DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, 100675812);
			}

			// Token: 0x0600D3A7 RID: 54183 RVA: 0x003307C0 File Offset: 0x0032E9C0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3A8 RID: 54184 RVA: 0x003307FC File Offset: 0x0032E9FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202994, XrefRangeEnd = 202995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEntry_b__0(Entry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D3A9 RID: 54185 RVA: 0x000669F6 File Offset: 0x00064BF6
			public __c__DisplayClass2_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004186 RID: 16774
			// (get) Token: 0x0600D3AA RID: 54186 RVA: 0x00330850 File Offset: 0x0032EA50
			// (set) Token: 0x0600D3AB RID: 54187 RVA: 0x000669FF File Offset: 0x00064BFF
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EE7 RID: 36583
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008EE8 RID: 36584
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EE9 RID: 36585
			private static readonly System.IntPtr NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0;
		}
	}
}
