using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001D3 RID: 467
	[System.Serializable]
	public class QuestStateSetter : Il2CppSystem.Object
	{
		// Token: 0x06002764 RID: 10084 RVA: 0x000EF068 File Offset: 0x000ED268
		// Note: this type is marked as 'beforefieldinit'.
		static QuestStateSetter()
		{
			Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestStateSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr);
			QuestStateSetter.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestName");
			QuestStateSetter.NativeFieldInfoPtr_SetQuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "SetQuestState");
			QuestStateSetter.NativeFieldInfoPtr_QuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestState");
			QuestStateSetter.NativeFieldInfoPtr_SetQuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "SetQuestEntryState");
			QuestStateSetter.NativeFieldInfoPtr_QuestEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestEntryIndex");
			QuestStateSetter.NativeFieldInfoPtr_QuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestEntryState");
			QuestStateSetter.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, 100667740);
			QuestStateSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, 100667741);
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000EF138 File Offset: 0x000ED338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120993, RefRangeEnd = 120994, XrefRangeStart = 120974, XrefRangeEnd = 120993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestStateSetter.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x000EF16C File Offset: 0x000ED36C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestStateSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestStateSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00015B49 File Offset: 0x00013D49
		public QuestStateSetter(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x000EF1A8 File Offset: 0x000ED3A8
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x00015B52 File Offset: 0x00013D52
		public unsafe string QuestName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x000EF1D0 File Offset: 0x000ED3D0
		// (set) Token: 0x0600276B RID: 10091 RVA: 0x00015B71 File Offset: 0x00013D71
		public unsafe bool SetQuestState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestState)) = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x000EF1F8 File Offset: 0x000ED3F8
		// (set) Token: 0x0600276D RID: 10093 RVA: 0x00015B8C File Offset: 0x00013D8C
		public unsafe QuestManager.EQuestAction QuestState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestState)) = value;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000EF220 File Offset: 0x000ED420
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x00015BA7 File Offset: 0x00013DA7
		public unsafe bool SetQuestEntryState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestEntryState)) = value;
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x000EF248 File Offset: 0x000ED448
		// (set) Token: 0x06002771 RID: 10097 RVA: 0x00015BC2 File Offset: 0x00013DC2
		public unsafe int QuestEntryIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryIndex)) = value;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x000EF270 File Offset: 0x000ED470
		// (set) Token: 0x06002773 RID: 10099 RVA: 0x00015BDD File Offset: 0x00013DDD
		public unsafe EQuestState QuestEntryState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryState)) = value;
			}
		}

		// Token: 0x04001A30 RID: 6704
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x04001A31 RID: 6705
		private static readonly System.IntPtr NativeFieldInfoPtr_SetQuestState;

		// Token: 0x04001A32 RID: 6706
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestState;

		// Token: 0x04001A33 RID: 6707
		private static readonly System.IntPtr NativeFieldInfoPtr_SetQuestEntryState;

		// Token: 0x04001A34 RID: 6708
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestEntryIndex;

		// Token: 0x04001A35 RID: 6709
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestEntryState;

		// Token: 0x04001A36 RID: 6710
		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x04001A37 RID: 6711
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
