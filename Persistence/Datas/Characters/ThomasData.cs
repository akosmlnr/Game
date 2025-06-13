using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas.Characters
{
	// Token: 0x020002E1 RID: 737
	public class ThomasData : NPCData
	{
		// Token: 0x06003388 RID: 13192 RVA: 0x00117384 File Offset: 0x00115584
		// Note: this type is marked as 'beforefieldinit'.
		static ThomasData()
		{
			Il2CppClassPointerStore<ThomasData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas.Characters", "ThomasData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThomasData>.NativeClassPtr);
			ThomasData.NativeFieldInfoPtr_MeetingReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, "MeetingReminderSent");
			ThomasData.NativeFieldInfoPtr_HandoverReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, "HandoverReminderSent");
			ThomasData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, 100669111);
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x001173F0 File Offset: 0x001155F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137294, XrefRangeEnd = 137296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThomasData(string id, bool meetingReminderSent, bool handoverReminderSent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThomasData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meetingReminderSent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverReminderSent;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThomasData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x0001B665 File Offset: 0x00019865
		public ThomasData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x0600338B RID: 13195 RVA: 0x00117458 File Offset: 0x00115658
		// (set) Token: 0x0600338C RID: 13196 RVA: 0x0001B66E File Offset: 0x0001986E
		public unsafe bool MeetingReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_MeetingReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_MeetingReminderSent)) = value;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x0600338D RID: 13197 RVA: 0x00117480 File Offset: 0x00115680
		// (set) Token: 0x0600338E RID: 13198 RVA: 0x0001B689 File Offset: 0x00019889
		public unsafe bool HandoverReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_HandoverReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_HandoverReminderSent)) = value;
			}
		}

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeFieldInfoPtr_MeetingReminderSent;

		// Token: 0x04002162 RID: 8546
		private static readonly IntPtr NativeFieldInfoPtr_HandoverReminderSent;

		// Token: 0x04002163 RID: 8547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0;
	}
}
