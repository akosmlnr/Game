using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000189 RID: 393
	[System.Serializable]
	public class Conditions : Il2CppSystem.Object
	{
		// Token: 0x06001F08 RID: 7944 RVA: 0x000D3FCC File Offset: 0x000D21CC
		// Note: this type is marked as 'beforefieldinit'.
		static Conditions()
		{
			Il2CppClassPointerStore<Conditions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "Conditions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Conditions>.NativeClassPtr);
			Conditions.NativeFieldInfoPtr_EvaluationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "EvaluationType");
			Conditions.NativeFieldInfoPtr_ConditionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "ConditionList");
			Conditions.NativeFieldInfoPtr_QuestConditionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "QuestConditionList");
			Conditions.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conditions>.NativeClassPtr, 100666846);
			Conditions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conditions>.NativeClassPtr, 100666847);
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x000D4060 File Offset: 0x000D2260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110913, RefRangeEnd = 110915, XrefRangeStart = 110902, XrefRangeEnd = 110913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Conditions.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x000D409C File Offset: 0x000D229C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Conditions() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Conditions>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conditions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x0001161C File Offset: 0x0000F81C
		public Conditions(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000D40D8 File Offset: 0x000D22D8
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x00011625 File Offset: 0x0000F825
		public unsafe Conditions.EEvaluationType EvaluationType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_EvaluationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_EvaluationType)) = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000D4100 File Offset: 0x000D2300
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x00011640 File Offset: 0x0000F840
		public unsafe Il2CppReferenceArray<Condition> ConditionList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_ConditionList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Condition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_ConditionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000D4130 File Offset: 0x000D2330
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x0001165F File Offset: 0x0000F85F
		public unsafe Il2CppReferenceArray<QuestCondition> QuestConditionList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_QuestConditionList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestCondition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_QuestConditionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014A1 RID: 5281
		private static readonly System.IntPtr NativeFieldInfoPtr_EvaluationType;

		// Token: 0x040014A2 RID: 5282
		private static readonly System.IntPtr NativeFieldInfoPtr_ConditionList;

		// Token: 0x040014A3 RID: 5283
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestConditionList;

		// Token: 0x040014A4 RID: 5284
		private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008E0 RID: 2272
		[OriginalName("Assembly-CSharp.dll", "", "EEvaluationType")]
		public enum EEvaluationType
		{
			// Token: 0x0400874A RID: 34634
			And,
			// Token: 0x0400874B RID: 34635
			Or
		}
	}
}
