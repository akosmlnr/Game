using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000639 RID: 1593
	public class ACSelection<T> : MonoBehaviour where T : UnityEngine.Object
	{
		// Token: 0x06008BAD RID: 35757 RVA: 0x0024D370 File Offset: 0x0024B570
		// Note: this type is marked as 'beforefieldinit'.
		static ACSelection()
		{
			Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACSelection`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr);
			ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "ButtonPrefab");
			ACSelection<T>.NativeFieldInfoPtr_PropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "PropertyIndex");
			ACSelection<T>.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "Options");
			ACSelection<T>.NativeFieldInfoPtr_Nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "Nullable");
			ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "DefaultOptionIndex");
			ACSelection<T>.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "buttons");
			ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "SelectedOptionIndex");
			ACSelection<T>.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "onValueChange");
			ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "onValueChangeWithIndex");
			ACSelection<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680787);
			ACSelection<T>.NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680788);
			ACSelection<T>.NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680789);
			ACSelection<T>.NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680790);
			ACSelection<T>.NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680791);
			ACSelection<T>.NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680792);
			ACSelection<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680793);
		}

		// Token: 0x06008BAE RID: 35758 RVA: 0x0024D51C File Offset: 0x0024B71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257392, XrefRangeEnd = 257424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BAF RID: 35759 RVA: 0x0024D558 File Offset: 0x0024B758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257428, RefRangeEnd = 257429, XrefRangeStart = 257424, XrefRangeEnd = 257428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectOption(int index, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref notify;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BB0 RID: 35760 RVA: 0x0024D5A4 File Offset: 0x0024B7A4
		[CallerCount(0)]
		public unsafe virtual void CallValueChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BB1 RID: 35761 RVA: 0x0024D5E0 File Offset: 0x0024B7E0
		[CallerCount(0)]
		public unsafe virtual string GetOptionLabel(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x0024D630 File Offset: 0x0024B830
		[CallerCount(0)]
		public unsafe virtual int GetAssetPathIndex(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x0024D688 File Offset: 0x0024B888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257429, XrefRangeEnd = 257438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonHighlighted(int buttonIndex, bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref buttonIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref h;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x0024D6D4 File Offset: 0x0024B8D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257457, RefRangeEnd = 257460, XrefRangeStart = 257438, XrefRangeEnd = 257457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACSelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BB5 RID: 35765 RVA: 0x00042694 File Offset: 0x00040894
		public ACSelection(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x06008BB6 RID: 35766 RVA: 0x0024D710 File Offset: 0x0024B910
		// (set) Token: 0x06008BB7 RID: 35767 RVA: 0x0004269D File Offset: 0x0004089D
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x06008BB8 RID: 35768 RVA: 0x0024D740 File Offset: 0x0024B940
		// (set) Token: 0x06008BB9 RID: 35769 RVA: 0x000426BC File Offset: 0x000408BC
		public unsafe int PropertyIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_PropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_PropertyIndex)) = value;
			}
		}

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x06008BBA RID: 35770 RVA: 0x0024D768 File Offset: 0x0024B968
		// (set) Token: 0x06008BBB RID: 35771 RVA: 0x000426D7 File Offset: 0x000408D7
		public unsafe List<T> Options
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Options);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x06008BBC RID: 35772 RVA: 0x0024D798 File Offset: 0x0024B998
		// (set) Token: 0x06008BBD RID: 35773 RVA: 0x000426F6 File Offset: 0x000408F6
		public unsafe bool Nullable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Nullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Nullable)) = value;
			}
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x06008BBE RID: 35774 RVA: 0x0024D7C0 File Offset: 0x0024B9C0
		// (set) Token: 0x06008BBF RID: 35775 RVA: 0x00042711 File Offset: 0x00040911
		public unsafe int DefaultOptionIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex)) = value;
			}
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x06008BC0 RID: 35776 RVA: 0x0024D7E8 File Offset: 0x0024B9E8
		// (set) Token: 0x06008BC1 RID: 35777 RVA: 0x0004272C File Offset: 0x0004092C
		public unsafe List<GameObject> buttons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_buttons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x06008BC2 RID: 35778 RVA: 0x0024D818 File Offset: 0x0024BA18
		// (set) Token: 0x06008BC3 RID: 35779 RVA: 0x0004274B File Offset: 0x0004094B
		public unsafe int SelectedOptionIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex)) = value;
			}
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x06008BC4 RID: 35780 RVA: 0x0024D840 File Offset: 0x0024BA40
		// (set) Token: 0x06008BC5 RID: 35781 RVA: 0x00042766 File Offset: 0x00040966
		public unsafe UnityEvent<T> onValueChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x06008BC6 RID: 35782 RVA: 0x0024D870 File Offset: 0x0024BA70
		// (set) Token: 0x06008BC7 RID: 35783 RVA: 0x00042785 File Offset: 0x00040985
		public unsafe UnityEvent<T, int> onValueChangeWithIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T, int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005EE0 RID: 24288
		private static readonly System.IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x04005EE1 RID: 24289
		private static readonly System.IntPtr NativeFieldInfoPtr_PropertyIndex;

		// Token: 0x04005EE2 RID: 24290
		private static readonly System.IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04005EE3 RID: 24291
		private static readonly System.IntPtr NativeFieldInfoPtr_Nullable;

		// Token: 0x04005EE4 RID: 24292
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultOptionIndex;

		// Token: 0x04005EE5 RID: 24293
		private static readonly System.IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x04005EE6 RID: 24294
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectedOptionIndex;

		// Token: 0x04005EE7 RID: 24295
		private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;

		// Token: 0x04005EE8 RID: 24296
		private static readonly System.IntPtr NativeFieldInfoPtr_onValueChangeWithIndex;

		// Token: 0x04005EE9 RID: 24297
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005EEA RID: 24298
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0;

		// Token: 0x04005EEB RID: 24299
		private static readonly System.IntPtr NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04005EEC RID: 24300
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04005EED RID: 24301
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04005EEE RID: 24302
		private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0;

		// Token: 0x04005EEF RID: 24303
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000B57 RID: 2903
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.ACSelection`1+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB9D RID: 56221 RVA: 0x0034699C File Offset: 0x00344B9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "<>c__DisplayClass9_0"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
				{
					Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr);
				ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, "index");
				ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, 100680794);
				ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, 100680795);
			}

			// Token: 0x0600DB9E RID: 56222 RVA: 0x00346A54 File Offset: 0x00344C54
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB9F RID: 56223 RVA: 0x00346A90 File Offset: 0x00344C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257389, XrefRangeEnd = 257392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBA0 RID: 56224 RVA: 0x0006A8FA File Offset: 0x00068AFA
			public __c__DisplayClass9_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BE RID: 17342
			// (get) Token: 0x0600DBA1 RID: 56225 RVA: 0x00346AC4 File Offset: 0x00344CC4
			// (set) Token: 0x0600DBA2 RID: 56226 RVA: 0x0006A903 File Offset: 0x00068B03
			public unsafe int index
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170043BF RID: 17343
			// (get) Token: 0x0600DBA3 RID: 56227 RVA: 0x00346AEC File Offset: 0x00344CEC
			// (set) Token: 0x0600DBA4 RID: 56228 RVA: 0x0006A91E File Offset: 0x00068B1E
			public unsafe ACSelection<T> __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACSelection<T>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093C2 RID: 37826
			private static readonly System.IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040093C3 RID: 37827
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093C4 RID: 37828
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093C5 RID: 37829
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
