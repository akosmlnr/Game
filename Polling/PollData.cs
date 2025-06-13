using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x02000202 RID: 514
	[System.Serializable]
	public class PollData : Il2CppSystem.Object
	{
		// Token: 0x06002922 RID: 10530 RVA: 0x000F564C File Offset: 0x000F384C
		// Note: this type is marked as 'beforefieldinit'.
		static PollData()
		{
			Il2CppClassPointerStore<PollData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollData>.NativeClassPtr);
			PollData.NativeFieldInfoPtr_pollId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "pollId");
			PollData.NativeFieldInfoPtr_question = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "question");
			PollData.NativeFieldInfoPtr_answers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "answers");
			PollData.NativeFieldInfoPtr_winnerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "winnerIndex");
			PollData.NativeFieldInfoPtr_confirmationMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "confirmationMessage");
			PollData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollData>.NativeClassPtr, 100667968);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000F56F4 File Offset: 0x000F38F4
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000163F6 File Offset: 0x000145F6
		public PollData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x000F5730 File Offset: 0x000F3930
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x000163FF File Offset: 0x000145FF
		public unsafe int pollId
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_pollId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_pollId)) = value;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x000F5758 File Offset: 0x000F3958
		// (set) Token: 0x06002928 RID: 10536 RVA: 0x0001641A File Offset: 0x0001461A
		public unsafe string question
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_question);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_question), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x000F5780 File Offset: 0x000F3980
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x00016439 File Offset: 0x00014639
		public unsafe Il2CppStringArray answers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_answers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_answers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x000F57B0 File Offset: 0x000F39B0
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x00016458 File Offset: 0x00014658
		public unsafe int winnerIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_winnerIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_winnerIndex)) = value;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x000F57D8 File Offset: 0x000F39D8
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x00016473 File Offset: 0x00014673
		public unsafe string confirmationMessage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_confirmationMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_confirmationMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B48 RID: 6984
		private static readonly System.IntPtr NativeFieldInfoPtr_pollId;

		// Token: 0x04001B49 RID: 6985
		private static readonly System.IntPtr NativeFieldInfoPtr_question;

		// Token: 0x04001B4A RID: 6986
		private static readonly System.IntPtr NativeFieldInfoPtr_answers;

		// Token: 0x04001B4B RID: 6987
		private static readonly System.IntPtr NativeFieldInfoPtr_winnerIndex;

		// Token: 0x04001B4C RID: 6988
		private static readonly System.IntPtr NativeFieldInfoPtr_confirmationMessage;

		// Token: 0x04001B4D RID: 6989
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
