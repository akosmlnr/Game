using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002CF RID: 719
	public class QuestManagerData : SaveData
	{
		// Token: 0x060032F2 RID: 13042 RVA: 0x00115B4C File Offset: 0x00113D4C
		// Note: this type is marked as 'beforefieldinit'.
		static QuestManagerData()
		{
			Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestManagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr);
			QuestManagerData.NativeFieldInfoPtr_Quests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr, "Quests");
			QuestManagerData.NativeFieldInfoPtr_Contracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr, "Contracts");
			QuestManagerData.NativeFieldInfoPtr_DeaddropQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr, "DeaddropQuests");
			QuestManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_QuestData_Il2CppReferenceArray_1_ContractData_Il2CppReferenceArray_1_DeaddropQuestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr, 100669087);
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x00115BCC File Offset: 0x00113DCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136668, RefRangeEnd = 136671, XrefRangeStart = 136668, XrefRangeEnd = 136671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestManagerData(Il2CppReferenceArray<QuestData> quests, Il2CppReferenceArray<ContractData> contracts, Il2CppReferenceArray<DeaddropQuestData> deaddropQuests) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(quests);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contracts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deaddropQuests);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_QuestData_Il2CppReferenceArray_1_ContractData_Il2CppReferenceArray_1_DeaddropQuestData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x0001B065 File Offset: 0x00019265
		public QuestManagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x00115C3C File Offset: 0x00113E3C
		// (set) Token: 0x060032F6 RID: 13046 RVA: 0x0001B06E File Offset: 0x0001926E
		public unsafe Il2CppReferenceArray<QuestData> Quests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_Quests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_Quests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x060032F7 RID: 13047 RVA: 0x00115C6C File Offset: 0x00113E6C
		// (set) Token: 0x060032F8 RID: 13048 RVA: 0x0001B08D File Offset: 0x0001928D
		public unsafe Il2CppReferenceArray<ContractData> Contracts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_Contracts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ContractData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_Contracts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x060032F9 RID: 13049 RVA: 0x00115C9C File Offset: 0x00113E9C
		// (set) Token: 0x060032FA RID: 13050 RVA: 0x0001B0AC File Offset: 0x000192AC
		public unsafe Il2CppReferenceArray<DeaddropQuestData> DeaddropQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_DeaddropQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeaddropQuestData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_DeaddropQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeFieldInfoPtr_Quests;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeFieldInfoPtr_Contracts;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropQuests;

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_QuestData_Il2CppReferenceArray_1_ContractData_Il2CppReferenceArray_1_DeaddropQuestData_0;
	}
}
