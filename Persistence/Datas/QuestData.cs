using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002CD RID: 717
	[Serializable]
	public class QuestData : SaveData
	{
		// Token: 0x060032D7 RID: 13015 RVA: 0x001156EC File Offset: 0x001138EC
		// Note: this type is marked as 'beforefieldinit'.
		static QuestData()
		{
			Il2CppClassPointerStore<QuestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestData>.NativeClassPtr);
			QuestData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "GUID");
			QuestData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "State");
			QuestData.NativeFieldInfoPtr_IsTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "IsTracked");
			QuestData.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Title");
			QuestData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Description");
			QuestData.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Expires");
			QuestData.NativeFieldInfoPtr_ExpiryDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "ExpiryDate");
			QuestData.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Entries");
			QuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestData>.NativeClassPtr, 100669084);
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x001157D0 File Offset: 0x001139D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137076, RefRangeEnd = 137079, XrefRangeStart = 137070, XrefRangeEnd = 137076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool expires, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expires;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x0001AF2D File Offset: 0x0001912D
		public QuestData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x00115894 File Offset: 0x00113A94
		// (set) Token: 0x060032DB RID: 13019 RVA: 0x0001AF36 File Offset: 0x00019136
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x001158BC File Offset: 0x00113ABC
		// (set) Token: 0x060032DD RID: 13021 RVA: 0x0001AF55 File Offset: 0x00019155
		public unsafe EQuestState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x001158E4 File Offset: 0x00113AE4
		// (set) Token: 0x060032DF RID: 13023 RVA: 0x0001AF70 File Offset: 0x00019170
		public unsafe bool IsTracked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_IsTracked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_IsTracked)) = value;
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x0011590C File Offset: 0x00113B0C
		// (set) Token: 0x060032E1 RID: 13025 RVA: 0x0001AF8B File Offset: 0x0001918B
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x060032E2 RID: 13026 RVA: 0x00115934 File Offset: 0x00113B34
		// (set) Token: 0x060032E3 RID: 13027 RVA: 0x0001AFAA File Offset: 0x000191AA
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x0011595C File Offset: 0x00113B5C
		// (set) Token: 0x060032E5 RID: 13029 RVA: 0x0001AFC9 File Offset: 0x000191C9
		public unsafe bool Expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x060032E6 RID: 13030 RVA: 0x00115984 File Offset: 0x00113B84
		// (set) Token: 0x060032E7 RID: 13031 RVA: 0x0001AFE4 File Offset: 0x000191E4
		public unsafe GameDateTimeData ExpiryDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_ExpiryDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_ExpiryDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x060032E8 RID: 13032 RVA: 0x001159B4 File Offset: 0x00113BB4
		// (set) Token: 0x060032E9 RID: 13033 RVA: 0x0001B003 File Offset: 0x00019203
		public unsafe Il2CppReferenceArray<QuestEntryData> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestEntryData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeFieldInfoPtr_IsTracked;

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeFieldInfoPtr_ExpiryDate;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0;
	}
}
