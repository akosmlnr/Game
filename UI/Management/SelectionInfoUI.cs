using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006F9 RID: 1785
	public class SelectionInfoUI : MonoBehaviour
	{
		// Token: 0x06009FC2 RID: 40898 RVA: 0x00288E6C File Offset: 0x0028706C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionInfoUI()
		{
			Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "SelectionInfoUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr);
			SelectionInfoUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "Icon");
			SelectionInfoUI.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "Title");
			SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "SelfUpdate");
			SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "NonUniformTypeSprite");
			SelectionInfoUI.NativeFieldInfoPtr_CrossSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "CrossSprite");
			SelectionInfoUI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100683002);
			SelectionInfoUI.NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100683003);
			SelectionInfoUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100683004);
		}

		// Token: 0x06009FC3 RID: 40899 RVA: 0x00288F3C File Offset: 0x0028713C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283463, XrefRangeEnd = 283490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FC4 RID: 40900 RVA: 0x00288F70 File Offset: 0x00287170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283523, RefRangeEnd = 283525, XrefRangeStart = 283490, XrefRangeEnd = 283523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(List<IConfigurable> Configurables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Configurables);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FC5 RID: 40901 RVA: 0x00288FB4 File Offset: 0x002871B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283525, XrefRangeEnd = 283526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionInfoUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FC6 RID: 40902 RVA: 0x0004E247 File Offset: 0x0004C447
		public SelectionInfoUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x06009FC7 RID: 40903 RVA: 0x00288FF0 File Offset: 0x002871F0
		// (set) Token: 0x06009FC8 RID: 40904 RVA: 0x0004E250 File Offset: 0x0004C450
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x06009FC9 RID: 40905 RVA: 0x00289020 File Offset: 0x00287220
		// (set) Token: 0x06009FCA RID: 40906 RVA: 0x0004E26F File Offset: 0x0004C46F
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x06009FCB RID: 40907 RVA: 0x00289050 File Offset: 0x00287250
		// (set) Token: 0x06009FCC RID: 40908 RVA: 0x0004E28E File Offset: 0x0004C48E
		public unsafe bool SelfUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate)) = value;
			}
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x00289078 File Offset: 0x00287278
		// (set) Token: 0x06009FCE RID: 40910 RVA: 0x0004E2A9 File Offset: 0x0004C4A9
		public unsafe Sprite NonUniformTypeSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x06009FCF RID: 40911 RVA: 0x002890A8 File Offset: 0x002872A8
		// (set) Token: 0x06009FD0 RID: 40912 RVA: 0x0004E2C8 File Offset: 0x0004C4C8
		public unsafe Sprite CrossSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_CrossSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_CrossSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B4F RID: 27471
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04006B50 RID: 27472
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04006B51 RID: 27473
		private static readonly IntPtr NativeFieldInfoPtr_SelfUpdate;

		// Token: 0x04006B52 RID: 27474
		private static readonly IntPtr NativeFieldInfoPtr_NonUniformTypeSprite;

		// Token: 0x04006B53 RID: 27475
		private static readonly IntPtr NativeFieldInfoPtr_CrossSprite;

		// Token: 0x04006B54 RID: 27476
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006B55 RID: 27477
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0;

		// Token: 0x04006B56 RID: 27478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
