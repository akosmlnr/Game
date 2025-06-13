using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000610 RID: 1552
	[Serializable]
	public class QualityItemDefinition : StorableItemDefinition
	{
		// Token: 0x060086BC RID: 34492 RVA: 0x0023E860 File Offset: 0x0023CA60
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemDefinition()
		{
			Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "QualityItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr);
			QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, "DefaultQuality");
			QualityItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, 100680263);
			QualityItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, 100680264);
		}

		// Token: 0x060086BD RID: 34493 RVA: 0x0023E8CC File Offset: 0x0023CACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252838, XrefRangeEnd = 252844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060086BE RID: 34494 RVA: 0x0023E924 File Offset: 0x0023CB24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252852, RefRangeEnd = 252853, XrefRangeStart = 252844, XrefRangeEnd = 252852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086BF RID: 34495 RVA: 0x0003F9BA File Offset: 0x0003DBBA
		public QualityItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x060086C0 RID: 34496 RVA: 0x0023E960 File Offset: 0x0023CB60
		// (set) Token: 0x060086C1 RID: 34497 RVA: 0x0003F9C3 File Offset: 0x0003DBC3
		public unsafe EQuality DefaultQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality)) = value;
			}
		}

		// Token: 0x04005BCD RID: 23501
		private static readonly IntPtr NativeFieldInfoPtr_DefaultQuality;

		// Token: 0x04005BCE RID: 23502
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005BCF RID: 23503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
