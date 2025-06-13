using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x0200018B RID: 395
	[System.Serializable]
	public class QuestCondition : Il2CppSystem.Object
	{
		// Token: 0x06001F17 RID: 7959 RVA: 0x000D4334 File Offset: 0x000D2534
		// Note: this type is marked as 'beforefieldinit'.
		static QuestCondition()
		{
			Il2CppClassPointerStore<QuestCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "QuestCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr);
			QuestCondition.NativeFieldInfoPtr_CheckQuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "CheckQuestState");
			QuestCondition.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestName");
			QuestCondition.NativeFieldInfoPtr_QuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestState");
			QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "CheckQuestEntryState");
			QuestCondition.NativeFieldInfoPtr_QuestEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestEntryIndex");
			QuestCondition.NativeFieldInfoPtr_QuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestEntryState");
			QuestCondition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, 100666851);
			QuestCondition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, 100666852);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x000D4404 File Offset: 0x000D2604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110931, XrefRangeEnd = 110947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(QuestCondition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000D4440 File Offset: 0x000D2640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110947, XrefRangeEnd = 110952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestCondition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestCondition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00011687 File Offset: 0x0000F887
		public QuestCondition(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x000D447C File Offset: 0x000D267C
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x00011690 File Offset: 0x0000F890
		public unsafe bool CheckQuestState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestState)) = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x000D44A4 File Offset: 0x000D26A4
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x000116AB File Offset: 0x0000F8AB
		public unsafe string QuestName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x000D44CC File Offset: 0x000D26CC
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x000116CA File Offset: 0x0000F8CA
		public unsafe EQuestState QuestState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestState)) = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x000D44F4 File Offset: 0x000D26F4
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x000116E5 File Offset: 0x0000F8E5
		public unsafe bool CheckQuestEntryState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState)) = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x000D451C File Offset: 0x000D271C
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x00011700 File Offset: 0x0000F900
		public unsafe int QuestEntryIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryIndex)) = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x000D4544 File Offset: 0x000D2744
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x0001171B File Offset: 0x0000F91B
		public unsafe EQuestState QuestEntryState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryState)) = value;
			}
		}

		// Token: 0x040014A9 RID: 5289
		private static readonly System.IntPtr NativeFieldInfoPtr_CheckQuestState;

		// Token: 0x040014AA RID: 5290
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x040014AB RID: 5291
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestState;

		// Token: 0x040014AC RID: 5292
		private static readonly System.IntPtr NativeFieldInfoPtr_CheckQuestEntryState;

		// Token: 0x040014AD RID: 5293
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestEntryIndex;

		// Token: 0x040014AE RID: 5294
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestEntryState;

		// Token: 0x040014AF RID: 5295
		private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
