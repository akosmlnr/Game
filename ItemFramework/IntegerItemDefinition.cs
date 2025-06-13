using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000602 RID: 1538
	[Serializable]
	public class IntegerItemDefinition : StorableItemDefinition
	{
		// Token: 0x06008593 RID: 34195 RVA: 0x0023A444 File Offset: 0x00238644
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemDefinition()
		{
			Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IntegerItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr);
			IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, "DefaultValue");
			IntegerItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, 100680107);
			IntegerItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, 100680108);
		}

		// Token: 0x06008594 RID: 34196 RVA: 0x0023A4B0 File Offset: 0x002386B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251053, XrefRangeEnd = 251057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008595 RID: 34197 RVA: 0x0023A508 File Offset: 0x00238708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008596 RID: 34198 RVA: 0x0003F2A6 File Offset: 0x0003D4A6
		public IntegerItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x06008597 RID: 34199 RVA: 0x0023A544 File Offset: 0x00238744
		// (set) Token: 0x06008598 RID: 34200 RVA: 0x0003F2AF File Offset: 0x0003D4AF
		public unsafe int DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x04005AF0 RID: 23280
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x04005AF1 RID: 23281
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005AF2 RID: 23282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
