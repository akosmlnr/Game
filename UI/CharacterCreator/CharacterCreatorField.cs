using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000726 RID: 1830
	public class CharacterCreatorField<T> : BaseCharacterCreatorField
	{
		// Token: 0x0600A34A RID: 41802 RVA: 0x00293AA4 File Offset: 0x00291CA4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorField()
		{
			Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorField`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr);
			CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, "<value>k__BackingField");
			CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, "selectedClothingDefinition");
			CharacterCreatorField<T>.NativeMethodInfoPtr_get_value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100683363);
			CharacterCreatorField<T>.NativeMethodInfoPtr_set_value_Protected_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100683364);
			CharacterCreatorField<T>.NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100683365);
			CharacterCreatorField<T>.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100683366);
			CharacterCreatorField<T>.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100683367);
			CharacterCreatorField<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100683368);
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600A34B RID: 41803 RVA: 0x00293BB0 File Offset: 0x00291DB0
		// (set) Token: 0x0600A34C RID: 41804 RVA: 0x00293BEC File Offset: 0x00291DEC
		public unsafe T value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr_get_value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				ref System.IntPtr ptr2 = ref *ptr;
				System.IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				System.IntPtr returnedException;
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr_set_value_Protected_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x00293C64 File Offset: 0x00291E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287218, XrefRangeEnd = 287223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T ReadValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x00293CA8 File Offset: 0x00291EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287223, XrefRangeEnd = 287233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(bool applyValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref applyValue;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x00293CF4 File Offset: 0x00291EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287234, RefRangeEnd = 287235, XrefRangeStart = 287233, XrefRangeEnd = 287234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x00293D30 File Offset: 0x00291F30
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x0005018D File Offset: 0x0004E38D
		public CharacterCreatorField(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600A352 RID: 41810 RVA: 0x00293D6C File Offset: 0x00291F6C
		// (set) Token: 0x0600A353 RID: 41811 RVA: 0x00293D94 File Offset: 0x00291F94
		public unsafe T _value_k__BackingField
		{
			get
			{
				System.IntPtr objectPointer = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, true, false);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr intPtr2 = intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField);
				System.Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						System.IntPtr gcObj;
						System.IntPtr intPtr3 = gcObj = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							gcObj = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								System.IntPtr obj = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(obj), (System.UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, gcObj);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600A354 RID: 41812 RVA: 0x00293E3C File Offset: 0x0029203C
		// (set) Token: 0x0600A355 RID: 41813 RVA: 0x00050196 File Offset: 0x0004E396
		public unsafe ClothingDefinition selectedClothingDefinition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D7B RID: 28027
		private static readonly System.IntPtr NativeFieldInfoPtr__value_k__BackingField;

		// Token: 0x04006D7C RID: 28028
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedClothingDefinition;

		// Token: 0x04006D7D RID: 28029
		private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_T_0;

		// Token: 0x04006D7E RID: 28030
		private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Protected_set_Void_T_0;

		// Token: 0x04006D7F RID: 28031
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0;

		// Token: 0x04006D80 RID: 28032
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006D81 RID: 28033
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006D82 RID: 28034
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
