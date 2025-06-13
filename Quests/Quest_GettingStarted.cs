using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.NPCs.CharacterClasses;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C7 RID: 455
	public class Quest_GettingStarted : Quest
	{
		// Token: 0x060026BF RID: 9919 RVA: 0x000ED274 File Offset: 0x000EB474
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_GettingStarted()
		{
			Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_GettingStarted");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr);
			Quest_GettingStarted.NativeFieldInfoPtr_CashAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "CashAmount");
			Quest_GettingStarted.NativeFieldInfoPtr_CashDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "CashDrop");
			Quest_GettingStarted.NativeFieldInfoPtr_Nelson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "Nelson");
			Quest_GettingStarted.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667672);
			Quest_GettingStarted.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667673);
			Quest_GettingStarted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667674);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x000ED31C File Offset: 0x000EB51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120234, XrefRangeEnd = 120235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GettingStarted.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000ED358 File Offset: 0x000EB558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120235, XrefRangeEnd = 120236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GettingStarted.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x000ED3B0 File Offset: 0x000EB5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120236, XrefRangeEnd = 120240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_GettingStarted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GettingStarted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00015606 File Offset: 0x00013806
		public Quest_GettingStarted(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x000ED3EC File Offset: 0x000EB5EC
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x0001560F File Offset: 0x0001380F
		public unsafe float CashAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashAmount)) = value;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000ED414 File Offset: 0x000EB614
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x0001562A File Offset: 0x0001382A
		public unsafe DeadDrop CashDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashDrop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashDrop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x000ED444 File Offset: 0x000EB644
		// (set) Token: 0x060026C9 RID: 9929 RVA: 0x00015649 File Offset: 0x00013849
		public unsafe UncleNelson Nelson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_Nelson);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UncleNelson>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_Nelson), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeFieldInfoPtr_CashAmount;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeFieldInfoPtr_CashDrop;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeFieldInfoPtr_Nelson;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
