using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027C RID: 636
	[Serializable]
	public class CashData : ItemData
	{
		// Token: 0x06003059 RID: 12377 RVA: 0x0010E4B0 File Offset: 0x0010C6B0
		// Note: this type is marked as 'beforefieldinit'.
		static CashData()
		{
			Il2CppClassPointerStore<CashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashData>.NativeClassPtr);
			CashData.NativeFieldInfoPtr_CashBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashData>.NativeClassPtr, "CashBalance");
			CashData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashData>.NativeClassPtr, 100669000);
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x0010E508 File Offset: 0x0010C708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136632, RefRangeEnd = 136634, XrefRangeStart = 136630, XrefRangeEnd = 136632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashData(string iD, int quantity, float cashBalance) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cashBalance;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x000194D4 File Offset: 0x000176D4
		public CashData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x0010E570 File Offset: 0x0010C770
		// (set) Token: 0x0600305D RID: 12381 RVA: 0x000194DD File Offset: 0x000176DD
		public unsafe float CashBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashData.NativeFieldInfoPtr_CashBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashData.NativeFieldInfoPtr_CashBalance)) = value;
			}
		}

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeFieldInfoPtr_CashBalance;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
	}
}
