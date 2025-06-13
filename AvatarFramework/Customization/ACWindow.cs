using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200063A RID: 1594
	public class ACWindow : MonoBehaviour
	{
		// Token: 0x06008BC8 RID: 35784 RVA: 0x0024D8A0 File Offset: 0x0024BAA0
		// Note: this type is marked as 'beforefieldinit'.
		static ACWindow()
		{
			Il2CppClassPointerStore<ACWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACWindow>.NativeClassPtr);
			ACWindow.NativeFieldInfoPtr_WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "WindowTitle");
			ACWindow.NativeFieldInfoPtr_Predecessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "Predecessor");
			ACWindow.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "TitleText");
			ACWindow.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "BackButton");
			ACWindow.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680796);
			ACWindow.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680797);
			ACWindow.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680798);
			ACWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680799);
		}

		// Token: 0x06008BC9 RID: 35785 RVA: 0x0024D970 File Offset: 0x0024BB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257460, XrefRangeEnd = 257480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BCA RID: 35786 RVA: 0x0024D9A4 File Offset: 0x0024BBA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199157, RefRangeEnd = 199158, XrefRangeStart = 199157, XrefRangeEnd = 199158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x0024D9D8 File Offset: 0x0024BBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257480, XrefRangeEnd = 257488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x0024DA0C File Offset: 0x0024BC0C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACWindow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACWindow>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x000427A4 File Offset: 0x000409A4
		public ACWindow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x06008BCE RID: 35790 RVA: 0x0024DA48 File Offset: 0x0024BC48
		// (set) Token: 0x06008BCF RID: 35791 RVA: 0x000427AD File Offset: 0x000409AD
		public unsafe string WindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_WindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_WindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x06008BD0 RID: 35792 RVA: 0x0024DA70 File Offset: 0x0024BC70
		// (set) Token: 0x06008BD1 RID: 35793 RVA: 0x000427CC File Offset: 0x000409CC
		public unsafe ACWindow Predecessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_Predecessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACWindow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_Predecessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x06008BD2 RID: 35794 RVA: 0x0024DAA0 File Offset: 0x0024BCA0
		// (set) Token: 0x06008BD3 RID: 35795 RVA: 0x000427EB File Offset: 0x000409EB
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x06008BD4 RID: 35796 RVA: 0x0024DAD0 File Offset: 0x0024BCD0
		// (set) Token: 0x06008BD5 RID: 35797 RVA: 0x0004280A File Offset: 0x00040A0A
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005EF0 RID: 24304
		private static readonly IntPtr NativeFieldInfoPtr_WindowTitle;

		// Token: 0x04005EF1 RID: 24305
		private static readonly IntPtr NativeFieldInfoPtr_Predecessor;

		// Token: 0x04005EF2 RID: 24306
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04005EF3 RID: 24307
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04005EF4 RID: 24308
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005EF5 RID: 24309
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005EF6 RID: 24310
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005EF7 RID: 24311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
