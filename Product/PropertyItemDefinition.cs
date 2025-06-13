using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Properties;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005D0 RID: 1488
	[Serializable]
	public class PropertyItemDefinition : StorableItemDefinition
	{
		// Token: 0x060081F1 RID: 33265 RVA: 0x0022E990 File Offset: 0x0022CB90
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyItemDefinition()
		{
			Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr);
			PropertyItemDefinition.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, "Properties");
			PropertyItemDefinition.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679709);
			PropertyItemDefinition.NativeMethodInfoPtr_HasProperty_Public_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679710);
			PropertyItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679711);
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x0022EA10 File Offset: 0x0022CC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247104, RefRangeEnd = 247105, XrefRangeStart = 247100, XrefRangeEnd = 247104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyItemDefinition.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x0022EA60 File Offset: 0x0022CC60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247109, RefRangeEnd = 247111, XrefRangeStart = 247105, XrefRangeEnd = 247109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertyItemDefinition.NativeMethodInfoPtr_HasProperty_Public_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x0022EAB0 File Offset: 0x0022CCB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247119, RefRangeEnd = 247120, XrefRangeStart = 247111, XrefRangeEnd = 247119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x0003D554 File Offset: 0x0003B754
		public PropertyItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x060081F6 RID: 33270 RVA: 0x0022EAEC File Offset: 0x0022CCEC
		// (set) Token: 0x060081F7 RID: 33271 RVA: 0x0003D55D File Offset: 0x0003B75D
		public unsafe List<Property> Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyItemDefinition.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyItemDefinition.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005892 RID: 22674
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04005893 RID: 22675
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Property_0;

		// Token: 0x04005894 RID: 22676
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_Property_0;

		// Token: 0x04005895 RID: 22677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
