using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001CC RID: 460
	public class Quest_SecuringSupplies : Quest
	{
		// Token: 0x060026E7 RID: 9959 RVA: 0x000ED9A4 File Offset: 0x000EBBA4
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_SecuringSupplies()
		{
			Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_SecuringSupplies");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr);
			Quest_SecuringSupplies.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr, "Supplier");
			Quest_SecuringSupplies.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr, 100667684);
			Quest_SecuringSupplies.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr, 100667685);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x000EDA10 File Offset: 0x000EBC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120344, XrefRangeEnd = 120346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SecuringSupplies.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000EDA4C File Offset: 0x000EBC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120346, XrefRangeEnd = 120350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_SecuringSupplies() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SecuringSupplies.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00015742 File Offset: 0x00013942
		public Quest_SecuringSupplies(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x000EDA88 File Offset: 0x000EBC88
		// (set) Token: 0x060026EC RID: 9964 RVA: 0x0001574B File Offset: 0x0001394B
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SecuringSupplies.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SecuringSupplies.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
