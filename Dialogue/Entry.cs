using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200045B RID: 1115
	[System.Serializable]
	public sealed class Entry : Il2CppSystem.ValueType
	{
		// Token: 0x060060A3 RID: 24739 RVA: 0x001BE460 File Offset: 0x001BC660
		// Note: this type is marked as 'beforefieldinit'.
		static Entry()
		{
			Il2CppClassPointerStore<Entry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "Entry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entry>.NativeClassPtr);
			Entry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "Key");
			Entry.NativeFieldInfoPtr_Chains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "Chains");
			Entry.NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entry>.NativeClassPtr, 100675707);
			Entry.NativeMethodInfoPtr_GetRandomLine_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entry>.NativeClassPtr, 100675708);
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x001BE4E0 File Offset: 0x001BC6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202120, XrefRangeEnd = 202121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetRandomChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entry.NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr2) : null;
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x001BE524 File Offset: 0x001BC724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202121, XrefRangeEnd = 202122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRandomLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Entry.NativeMethodInfoPtr_GetRandomLine_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x0002D532 File Offset: 0x0002B732
		public Entry(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x0002D53B File Offset: 0x0002B73B
		public Entry() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entry>.NativeClassPtr))
		{
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x060060A8 RID: 24744 RVA: 0x001BE560 File Offset: 0x001BC760
		// (set) Token: 0x060060A9 RID: 24745 RVA: 0x0002D54D File Offset: 0x0002B74D
		public unsafe string Key
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x060060AA RID: 24746 RVA: 0x001BE588 File Offset: 0x001BC788
		// (set) Token: 0x060060AB RID: 24747 RVA: 0x0002D56C File Offset: 0x0002B76C
		public unsafe Il2CppReferenceArray<DialogueChain> Chains
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Chains);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueChain>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Chains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004217 RID: 16919
		private static readonly System.IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x04004218 RID: 16920
		private static readonly System.IntPtr NativeFieldInfoPtr_Chains;

		// Token: 0x04004219 RID: 16921
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0;

		// Token: 0x0400421A RID: 16922
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomLine_Public_String_0;
	}
}
