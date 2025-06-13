using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x02000201 RID: 513
	[System.Serializable]
	public class PollAnswer : Il2CppSystem.Object
	{
		// Token: 0x06002919 RID: 10521 RVA: 0x000F54EC File Offset: 0x000F36EC
		// Note: this type is marked as 'beforefieldinit'.
		static PollAnswer()
		{
			Il2CppClassPointerStore<PollAnswer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollAnswer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr);
			PollAnswer.NativeFieldInfoPtr_pollId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr, "pollId");
			PollAnswer.NativeFieldInfoPtr_answer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr, "answer");
			PollAnswer.NativeFieldInfoPtr_ticket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr, "ticket");
			PollAnswer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr, 100667967);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000F556C File Offset: 0x000F376C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122063, XrefRangeEnd = 122065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollAnswer(int _pollId, int _answer, string _ticket) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _pollId;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _answer;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_ticket);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollAnswer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00016398 File Offset: 0x00014598
		public PollAnswer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x000F55D4 File Offset: 0x000F37D4
		// (set) Token: 0x0600291D RID: 10525 RVA: 0x000163A1 File Offset: 0x000145A1
		public unsafe int pollId
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_pollId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_pollId)) = value;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x0600291E RID: 10526 RVA: 0x000F55FC File Offset: 0x000F37FC
		// (set) Token: 0x0600291F RID: 10527 RVA: 0x000163BC File Offset: 0x000145BC
		public unsafe int answer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_answer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_answer)) = value;
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x000F5624 File Offset: 0x000F3824
		// (set) Token: 0x06002921 RID: 10529 RVA: 0x000163D7 File Offset: 0x000145D7
		public unsafe string ticket
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_ticket);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_ticket), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B44 RID: 6980
		private static readonly System.IntPtr NativeFieldInfoPtr_pollId;

		// Token: 0x04001B45 RID: 6981
		private static readonly System.IntPtr NativeFieldInfoPtr_answer;

		// Token: 0x04001B46 RID: 6982
		private static readonly System.IntPtr NativeFieldInfoPtr_ticket;

		// Token: 0x04001B47 RID: 6983
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0;
	}
}
