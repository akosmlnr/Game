using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000750 RID: 1872
	public class CashSlot : HotbarSlot
	{
		// Token: 0x0600A838 RID: 43064 RVA: 0x002A37D4 File Offset: 0x002A19D4
		// Note: this type is marked as 'beforefieldinit'.
		static CashSlot()
		{
			Il2CppClassPointerStore<CashSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "CashSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashSlot>.NativeClassPtr);
			CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, "MAX_CASH_PER_SLOT");
			CashSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100683952);
			CashSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100683953);
			CashSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100683954);
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x002A3854 File Offset: 0x002A1A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293561, XrefRangeEnd = 293565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A83A RID: 43066 RVA: 0x002A38A0 File Offset: 0x002A1AA0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A83B RID: 43067 RVA: 0x002A38E8 File Offset: 0x002A1AE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250812, RefRangeEnd = 250814, XrefRangeStart = 250812, XrefRangeEnd = 250814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashSlot>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A83C RID: 43068 RVA: 0x00052B9A File Offset: 0x00050D9A
		public CashSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600A83D RID: 43069 RVA: 0x002A3924 File Offset: 0x002A1B24
		// (set) Token: 0x0600A83E RID: 43070 RVA: 0x00052BA3 File Offset: 0x00050DA3
		public unsafe static float MAX_CASH_PER_SLOT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT, (void*)(&value));
			}
		}

		// Token: 0x040070C9 RID: 28873
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CASH_PER_SLOT;

		// Token: 0x040070CA RID: 28874
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x040070CB RID: 28875
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0;

		// Token: 0x040070CC RID: 28876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
