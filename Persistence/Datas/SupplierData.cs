using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AD RID: 685
	[Serializable]
	public class SupplierData : NPCData
	{
		// Token: 0x060031AA RID: 12714 RVA: 0x00111E40 File Offset: 0x00110040
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierData()
		{
			Il2CppClassPointerStore<SupplierData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SupplierData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierData>.NativeClassPtr);
			SupplierData.NativeFieldInfoPtr_timeSinceMeetingStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "timeSinceMeetingStart");
			SupplierData.NativeFieldInfoPtr_timeSinceLastMeetingEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "timeSinceLastMeetingEnd");
			SupplierData.NativeFieldInfoPtr_debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "debt");
			SupplierData.NativeFieldInfoPtr_minsUntilDeadDropReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "minsUntilDeadDropReady");
			SupplierData.NativeFieldInfoPtr_deaddropItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "deaddropItems");
			SupplierData.NativeFieldInfoPtr_debtReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "debtReminderSent");
			SupplierData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_Int32_Il2CppReferenceArray_1_StringIntPair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, 100669051);
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x00111EFC File Offset: 0x001100FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136886, RefRangeEnd = 136887, XrefRangeStart = 136883, XrefRangeEnd = 136886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierData(string id, int _timeSinceMeetingStart, int _timeSinceLastMeetingEnd, float _debt, int _minsUntilDeadDropReady, Il2CppReferenceArray<StringIntPair> _deaddropItems, bool _debtReminderSent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _timeSinceMeetingStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _timeSinceLastMeetingEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _debt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minsUntilDeadDropReady;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_deaddropItems);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _debtReminderSent;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_Int32_Il2CppReferenceArray_1_StringIntPair_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x0001A24B File Offset: 0x0001844B
		public SupplierData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x00111FA0 File Offset: 0x001101A0
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x0001A254 File Offset: 0x00018454
		public unsafe int timeSinceMeetingStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceMeetingStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceMeetingStart)) = value;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x00111FC8 File Offset: 0x001101C8
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x0001A26F File Offset: 0x0001846F
		public unsafe int timeSinceLastMeetingEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceLastMeetingEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceLastMeetingEnd)) = value;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x00111FF0 File Offset: 0x001101F0
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x0001A28A File Offset: 0x0001848A
		public unsafe float debt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debt)) = value;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x00112018 File Offset: 0x00110218
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x0001A2A5 File Offset: 0x000184A5
		public unsafe int minsUntilDeadDropReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_minsUntilDeadDropReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_minsUntilDeadDropReady)) = value;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x00112040 File Offset: 0x00110240
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x0001A2C0 File Offset: 0x000184C0
		public unsafe Il2CppReferenceArray<StringIntPair> deaddropItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_deaddropItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_deaddropItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x00112070 File Offset: 0x00110270
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x0001A2DF File Offset: 0x000184DF
		public unsafe bool debtReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debtReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debtReminderSent)) = value;
			}
		}

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceMeetingStart;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastMeetingEnd;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeFieldInfoPtr_debt;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeFieldInfoPtr_minsUntilDeadDropReady;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeFieldInfoPtr_deaddropItems;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeFieldInfoPtr_debtReminderSent;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_Int32_Il2CppReferenceArray_1_StringIntPair_Boolean_0;
	}
}
