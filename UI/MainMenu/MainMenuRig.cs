using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x0200070F RID: 1807
	public class MainMenuRig : MonoBehaviour
	{
		// Token: 0x0600A0FA RID: 41210 RVA: 0x0028CC80 File Offset: 0x0028AE80
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuRig()
		{
			Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MainMenuRig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr);
			MainMenuRig.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "Avatar");
			MainMenuRig.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "DefaultSettings");
			MainMenuRig.NativeFieldInfoPtr_CashPiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "CashPiles");
			MainMenuRig.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100683140);
			MainMenuRig.NativeMethodInfoPtr_LoadStuff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100683141);
			MainMenuRig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100683142);
		}

		// Token: 0x0600A0FB RID: 41211 RVA: 0x0028CD28 File Offset: 0x0028AF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284558, XrefRangeEnd = 284570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x0028CD5C File Offset: 0x0028AF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284570, XrefRangeEnd = 284610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr_LoadStuff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x0028CD90 File Offset: 0x0028AF90
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuRig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x0004EBDE File Offset: 0x0004CDDE
		public MainMenuRig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600A0FF RID: 41215 RVA: 0x0028CDCC File Offset: 0x0028AFCC
		// (set) Token: 0x0600A100 RID: 41216 RVA: 0x0004EBE7 File Offset: 0x0004CDE7
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600A101 RID: 41217 RVA: 0x0028CDFC File Offset: 0x0028AFFC
		// (set) Token: 0x0600A102 RID: 41218 RVA: 0x0004EC06 File Offset: 0x0004CE06
		public unsafe BasicAvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600A103 RID: 41219 RVA: 0x0028CE2C File Offset: 0x0028B02C
		// (set) Token: 0x0600A104 RID: 41220 RVA: 0x0004EC25 File Offset: 0x0004CE25
		public unsafe Il2CppReferenceArray<CashPile> CashPiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_CashPiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CashPile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_CashPiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C0F RID: 27663
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04006C10 RID: 27664
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04006C11 RID: 27665
		private static readonly IntPtr NativeFieldInfoPtr_CashPiles;

		// Token: 0x04006C12 RID: 27666
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006C13 RID: 27667
		private static readonly IntPtr NativeMethodInfoPtr_LoadStuff_Private_Void_0;

		// Token: 0x04006C14 RID: 27668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
