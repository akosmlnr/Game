using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000289 RID: 649
	[Serializable]
	public class LaunderOperationData : SaveData
	{
		// Token: 0x06003098 RID: 12440 RVA: 0x0010EF60 File Offset: 0x0010D160
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderOperationData()
		{
			Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LaunderOperationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr);
			LaunderOperationData.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, "Amount");
			LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, "MinutesSinceStarted");
			LaunderOperationData.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, 100669013);
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x0010EFCC File Offset: 0x0010D1CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136656, RefRangeEnd = 136657, XrefRangeStart = 136655, XrefRangeEnd = 136656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderOperationData(float amount, int minutesSinceStarted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderOperationData.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x00019781 File Offset: 0x00017981
		public LaunderOperationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x0010F024 File Offset: 0x0010D224
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x0001978A File Offset: 0x0001798A
		public unsafe float Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x0010F04C File Offset: 0x0010D24C
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x000197A5 File Offset: 0x000179A5
		public unsafe int MinutesSinceStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted)) = value;
			}
		}

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeFieldInfoPtr_MinutesSinceStarted;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0;
	}
}
