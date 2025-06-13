using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x020004CD RID: 1229
	public class CasinoGamePlayerDisplay : MonoBehaviour
	{
		// Token: 0x06006B27 RID: 27431 RVA: 0x001E21D8 File Offset: 0x001E03D8
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayerDisplay()
		{
			Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "CasinoGamePlayerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr);
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "BindedPlayers");
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "TitleLabel");
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "PlayerEntries");
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshPlayers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100677010);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshScores_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100677011);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100677012);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_Unbind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100677013);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100677014);
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x001E22A8 File Offset: 0x001E04A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216683, RefRangeEnd = 216684, XrefRangeStart = 216632, XrefRangeEnd = 216683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshPlayers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x001E22DC File Offset: 0x001E04DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216684, XrefRangeEnd = 216695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshScores_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x001E2310 File Offset: 0x001E0510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216711, RefRangeEnd = 216713, XrefRangeStart = 216695, XrefRangeEnd = 216711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(CasinoGamePlayers players)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(players);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x001E2354 File Offset: 0x001E0554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216731, RefRangeEnd = 216733, XrefRangeStart = 216713, XrefRangeEnd = 216731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unbind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_Unbind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B2C RID: 27436 RVA: 0x001E2388 File Offset: 0x001E0588
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B2D RID: 27437 RVA: 0x0003259F File Offset: 0x0003079F
		public CasinoGamePlayerDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06006B2E RID: 27438 RVA: 0x001E23C4 File Offset: 0x001E05C4
		// (set) Token: 0x06006B2F RID: 27439 RVA: 0x000325A8 File Offset: 0x000307A8
		public unsafe CasinoGamePlayers BindedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06006B30 RID: 27440 RVA: 0x001E23F4 File Offset: 0x001E05F4
		// (set) Token: 0x06006B31 RID: 27441 RVA: 0x000325C7 File Offset: 0x000307C7
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06006B32 RID: 27442 RVA: 0x001E2424 File Offset: 0x001E0624
		// (set) Token: 0x06006B33 RID: 27443 RVA: 0x000325E6 File Offset: 0x000307E6
		public unsafe Il2CppReferenceArray<RectTransform> PlayerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004970 RID: 18800
		private static readonly IntPtr NativeFieldInfoPtr_BindedPlayers;

		// Token: 0x04004971 RID: 18801
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04004972 RID: 18802
		private static readonly IntPtr NativeFieldInfoPtr_PlayerEntries;

		// Token: 0x04004973 RID: 18803
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPlayers_Public_Void_0;

		// Token: 0x04004974 RID: 18804
		private static readonly IntPtr NativeMethodInfoPtr_RefreshScores_Public_Void_0;

		// Token: 0x04004975 RID: 18805
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0;

		// Token: 0x04004976 RID: 18806
		private static readonly IntPtr NativeMethodInfoPtr_Unbind_Public_Void_0;

		// Token: 0x04004977 RID: 18807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
