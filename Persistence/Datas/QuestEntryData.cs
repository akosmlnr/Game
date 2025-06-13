using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002CE RID: 718
	[Serializable]
	public class QuestEntryData : SaveData
	{
		// Token: 0x060032EA RID: 13034 RVA: 0x001159E4 File Offset: 0x00113BE4
		// Note: this type is marked as 'beforefieldinit'.
		static QuestEntryData()
		{
			Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestEntryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr);
			QuestEntryData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, "Name");
			QuestEntryData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, "State");
			QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, 100669085);
			QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, 100669086);
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x00115A64 File Offset: 0x00113C64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 136648, RefRangeEnd = 136653, XrefRangeStart = 136648, XrefRangeEnd = 136653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData(string name, EQuestState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x00115AC0 File Offset: 0x00113CC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136226, RefRangeEnd = 136227, XrefRangeStart = 136226, XrefRangeEnd = 136227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x0001B022 File Offset: 0x00019222
		public QuestEntryData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x00115AFC File Offset: 0x00113CFC
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x0001B02B File Offset: 0x0001922B
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x00115B24 File Offset: 0x00113D24
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x0001B04A File Offset: 0x0001924A
		public unsafe EQuestState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
