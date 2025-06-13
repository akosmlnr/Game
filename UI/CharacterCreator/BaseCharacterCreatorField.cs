using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Customization;
using UnityEngine;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000724 RID: 1828
	public class BaseCharacterCreatorField : MonoBehaviour
	{
		// Token: 0x0600A329 RID: 41769 RVA: 0x002934D8 File Offset: 0x002916D8
		// Note: this type is marked as 'beforefieldinit'.
		static BaseCharacterCreatorField()
		{
			Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "BaseCharacterCreatorField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr);
			BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "PropertyName");
			BaseCharacterCreatorField.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "Category");
			BaseCharacterCreatorField.NativeFieldInfoPtr_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "Creator");
			BaseCharacterCreatorField.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100683351);
			BaseCharacterCreatorField.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100683352);
			BaseCharacterCreatorField.NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100683353);
			BaseCharacterCreatorField.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100683354);
			BaseCharacterCreatorField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100683355);
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x002935A8 File Offset: 0x002917A8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x002935E4 File Offset: 0x002917E4
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x00293620 File Offset: 0x00291820
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x0029365C File Offset: 0x0029185C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(bool applyValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref applyValue;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x002936A8 File Offset: 0x002918A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseCharacterCreatorField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCharacterCreatorField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x0005005A File Offset: 0x0004E25A
		public BaseCharacterCreatorField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600A330 RID: 41776 RVA: 0x002936E4 File Offset: 0x002918E4
		// (set) Token: 0x0600A331 RID: 41777 RVA: 0x00050063 File Offset: 0x0004E263
		public unsafe string PropertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600A332 RID: 41778 RVA: 0x0029370C File Offset: 0x0029190C
		// (set) Token: 0x0600A333 RID: 41779 RVA: 0x00050082 File Offset: 0x0004E282
		public unsafe CharacterCreator.ECategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600A334 RID: 41780 RVA: 0x00293734 File Offset: 0x00291934
		// (set) Token: 0x0600A335 RID: 41781 RVA: 0x0005009D File Offset: 0x0004E29D
		public unsafe CharacterCreator Creator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Creator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Creator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D68 RID: 28008
		private static readonly IntPtr NativeFieldInfoPtr_PropertyName;

		// Token: 0x04006D69 RID: 28009
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04006D6A RID: 28010
		private static readonly IntPtr NativeFieldInfoPtr_Creator;

		// Token: 0x04006D6B RID: 28011
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006D6C RID: 28012
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006D6D RID: 28013
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0;

		// Token: 0x04006D6E RID: 28014
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006D6F RID: 28015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
