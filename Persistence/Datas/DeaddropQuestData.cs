using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002CC RID: 716
	[Serializable]
	public class DeaddropQuestData : QuestData
	{
		// Token: 0x060032D2 RID: 13010 RVA: 0x00115594 File Offset: 0x00113794
		// Note: this type is marked as 'beforefieldinit'.
		static DeaddropQuestData()
		{
			Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DeaddropQuestData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr);
			DeaddropQuestData.NativeFieldInfoPtr_DeaddropGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr, "DeaddropGUID");
			DeaddropQuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr, 100669083);
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x001155EC File Offset: 0x001137EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137069, RefRangeEnd = 137070, XrefRangeStart = 137067, XrefRangeEnd = 137069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeaddropQuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries, string deaddropGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTimed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deaddropGUID);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeaddropQuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0001AF05 File Offset: 0x00019105
		public DeaddropQuestData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x060032D5 RID: 13013 RVA: 0x001156C4 File Offset: 0x001138C4
		// (set) Token: 0x060032D6 RID: 13014 RVA: 0x0001AF0E File Offset: 0x0001910E
		public unsafe string DeaddropGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeaddropQuestData.NativeFieldInfoPtr_DeaddropGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeaddropQuestData.NativeFieldInfoPtr_DeaddropGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropGUID;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_0;
	}
}
